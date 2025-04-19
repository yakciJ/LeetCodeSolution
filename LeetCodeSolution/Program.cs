namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 18/4/2025
        public static void Main()
        {
            Console.WriteLine(Solution(new int[] { 0, 1, 4, 4, 5, 7 }, 3, 6));
        }
        public static long Solution(int[] n, int lower, int upper)
        {
            Array.Sort(n);
            long first = 0;
            long last = n.Length - 1;
            long countUpper = 0;
            long countLower = 0;
            while (first < last)
            {
                long sum = n[first] + n[last];
                if (sum <= upper)
                {
                    countUpper += last - first;
                    first++;
                }
                else
                {
                    last--;
                }
            }
            first = 0;
            last = n.Length - 1;
            while (first < last)
            {
                long sum = n[first] + n[last];
                if (sum < lower)
                {
                    countLower += last - first;
                    first++;
                }
                else
                {
                    last--;
                }
            }
            return countUpper - countLower;
        }
    }
}

