namespace LeetCodeSolution
{
    class Program
    {
        // 27/05/2025 | 2894. Divisible and Non-divisible Sums Difference
        public static void Main()
        {
            Console.WriteLine(Solution(10, 3));
        }

        public static int Solution(int n, int m)
        {
            int num1 = 0, num2 = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0)
                {
                    num2 += i;
                }
                else num1 += i;
            }
            return num1 - num2;
        }
    }
}

