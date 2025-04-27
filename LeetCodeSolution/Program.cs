namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 27/04/2025 | 3392. Count Subarrays of Length Three With a Condition
        public static void Main()
        {
            Console.WriteLine(Solution(new int[] { 1, 2, 1, 4, 1 }));
        }
        public static int Solution(int[] nums)
        {
            int count = 0;
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i - 1] + nums[i + 1] == (double)nums[i] / 2)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

