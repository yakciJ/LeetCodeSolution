namespace LeetCodeSolution
{
    class Program
    {
        // 26/6/2025 | 2311. Longest Binary Subsequence Less Than or Equal to K

        public static void Main()
        {
            Console.WriteLine(Solution("00101001", 1));
        }
        public static int Solution(string s, int k)
        {
            string res = "";
            long number = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '0')
                {
                    res = s[i] + res;
                }
                else if (s[i] == '1')
                {
                    double tempNumber = number + Math.Pow(2, res.Length);
                    if (tempNumber <= k)
                    {
                        res = s[i] + res;
                        number = (long)tempNumber;
                    }
                }
            }
            return res.Length;
        }
    }
}