namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 21/04/2025
        public static void Main()
        {
            Console.WriteLine(Solution(new int[] { 1, -3, 4 }, 1, 6)); // Output: 2
            Console.WriteLine(Solution(new int[] { 3, -4, 5, 1, -2 }, -4, 5)); // Output: 4
            Console.WriteLine(Solution(new int[] { 4, -7, 2 }, 3, 6)); // Output: 0
            Console.WriteLine(Solution(new int[] { 0, 0, 0 }, 1, 1)); // Output: 1
        }
        public static int Solution(int[] differences, int lower, int upper)
        {
            int count = 0;
            long min = 0;
            long max = 0;
            long temp = 0;
            for (int j = 0; j < differences.Length; j++)
            {
                temp += differences[j];
                if (temp > max)
                {
                    max = temp;
                }
                if (temp < min)
                {
                    min = temp;
                }
            }
            for (int i = lower; i <= upper; i++)
            {
                if (i + max <= upper && i + min >= lower)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

