namespace LeetCodeSolution
{
    using System;
    using System.Linq;

    class Program
    {
        // 29/04/2025 | 2962. Count Subarrays Where Max Element Appears at Least K Times
        public static void Main()
        {
            Console.WriteLine(Solution(new int[] { 1, 3, 2, 3, 3 }, 2));
        }
        public static long Solution(int[] nums, long k)
        {
            long count = 0;
            int max = nums.Max();
            long numberOfMax = 0;
            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max)
                {
                    numberOfMax++;
                }
                while (numberOfMax == k)
                {
                    count += nums.Length - i;
                    if (nums[left] == max)
                    {
                        numberOfMax--;
                    }
                    left++;
                }
            }
            return count;
        }
    }
}

