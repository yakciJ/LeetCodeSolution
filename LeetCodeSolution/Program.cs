namespace LeetCodeSolution
{
    class Program
    {
        // 14/08/2025 | 2264. Largest 3-Same-Digit Number in String
        // ez
        // lam ez de danh thoi gian cho prj
        public static void Main()
        {
            Console.WriteLine(Solution("6777133339"));
            Console.WriteLine(Solution("2300019"));
            Console.WriteLine(Solution("42352338"));
        }

        public static string Solution(string num)
        {
            char present = num[0];
            int count = 1;
            int max = -1;
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] == present)
                {
                    count++;
                }
                else
                {
                    count = 1;
                    present = num[i];
                }
                if (count == 3)
                {
                    max = Math.Max(num[i] - '0', max);
                }
            }
            string a = max.ToString();
            if (a != "-1")
            {
                return a + a + a;
            }
            return "";
        }
    }
}



