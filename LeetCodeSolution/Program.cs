namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 23/04/2025
        public static void Main()
        {
            Console.WriteLine(Solution(2));  // 3
        }
        public static int Solution(int n)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int x = i;
                while (x > 0)
                {
                    sum += x % 10;
                    x /= 10;
                }
                if (freq.ContainsKey(sum))
                {
                    freq[sum]++;
                }
                else
                {
                    freq[sum] = 1;
                }
            }
            int max = 0;
            int count = 0;
            foreach (var key in freq)
            {
                Console.WriteLine($"{key}");
                if (max < key.Value)
                {
                    max = key.Value;
                    count = 1;
                }
                else if (max == key.Value)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

