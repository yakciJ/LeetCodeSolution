namespace LeetCodeSolution
{
    class Program
    {
        // 02/07/2025 | 2566. Maximum Difference by Remapping a Digit

        public static void Main()
        {
            Console.WriteLine(Solution(11891));
        }
        public static int Solution(int num)
        {
            int max = num;
            int min = num;
            string str = num.ToString();
            for (int i = 0; i < 10; i++)
            {
                char digitChar = (char)('0' + i);
                string result = str.Replace(digitChar, '9');
                if (int.Parse(result) > max)
                {
                    max = int.Parse(result);
                }
                result = str.Replace(digitChar, '0');
                if (int.Parse(result) < min)
                {
                    min = int.Parse(result);
                }
            }
            return max - min;
        }
    }
}