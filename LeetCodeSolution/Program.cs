namespace LeetCodeSolution
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        // 20/4/2025
        public static void Main()
        {
            Console.WriteLine(Solution(new int[] { 0, 0, 1, 1, 1 }));
        }
        public static int Solution(int[] n)
        {
            int minRabbit = 0;
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int i in n)
            {
                if (freq.ContainsKey(i))
                {
                    freq[i]++;
                }
                else
                {
                    freq[i] = 1;
                }
            }
            foreach (var num in freq)
            {
                int group = num.Key + 1;
                minRabbit += (int)Math.Ceiling((1.0 * num.Value) / group) * group;
            }
            return minRabbit;
        }
    }
}

