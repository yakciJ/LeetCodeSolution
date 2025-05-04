namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 04/05/2025 | 1128. Number of Equivalent Domino Pairs
        public static void Main()
        {
            int[][] dominoes = new int[][]
        {
            new int[] {1, 2},
            new int[] {2, 1},
            new int[] {3, 4},
            new int[] {5, 6}
        };

            Console.WriteLine(Solution(dominoes)); // Expected: 1
        }

        public static int Solution(int[][] dominoes)
        {
            int count = 0;
            Dictionary<(int, int), int> keyValuePairs = new Dictionary<(int, int), int>();
            for (int i = 0; i < dominoes.Length; i++)
            {
                int a = dominoes[i][0];
                int b = dominoes[i][1];
                var multiply = (Math.Max(a,b), Math.Min(a,b));
                if (keyValuePairs.ContainsKey(multiply))
                {
                    keyValuePairs[multiply]++;
                }
                else
                {
                    keyValuePairs[multiply] = 1;
                }
            }
            foreach (var value in keyValuePairs.Values)
            {
                if (value >= 2)
                {
                    count += value * (value - 1) / 2;
                }
            }
            return count;
        }
    }
}

