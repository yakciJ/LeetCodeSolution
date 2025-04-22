namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 22/04/2025
        public static void Main()
        {
            Console.WriteLine(Solution(1, 3));  // 3
            Console.WriteLine(Solution(2, 2));  // 3
            Console.WriteLine(Solution(2, 3));  // 5
            Console.WriteLine(Solution(3, 4));  // 13
            Console.WriteLine(Solution(4, 2));  // 5
            Console.WriteLine(Solution(5, 3));  // 11
            Console.WriteLine(Solution(6, 3));  // 13
        }
        public static int Solution(int length, int maxValue)
        {
            const int MOD = 1000000007;
            int[,] dp = new int[length + 1, maxValue + 1];
            for (int i = 1; i <= maxValue; i++)
            {
                dp[1, i] = 1;
            }
            for (int i = 2; i <= length; i++)
            {
                for (int j = 1; j <= maxValue; j++)
                {
                    for (int k = 1; k * k <= j; k++)
                    {
                        if (j % k == 0)
                        {
                            dp[i, j] = (dp[i, j] + dp[i - 1, k]) % MOD;
                            if (k != j / k)
                            {
                                dp[i, j] = (dp[i, j] + dp[i - 1, j / k]) % MOD;
                            }
                        }
                    }
                }
            }
            long result = 0;
            for (int j = 1; j <= maxValue; j++)
            {
                result = (result + dp[length, j]) % MOD;
            }
            return (int)result;
        }
    }
}

