namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 28/04/2025 | 2302. Count Subarrays With Score Less Than K
        public static void Main()
        {
            Console.WriteLine(Solution(new int[] { 2, 1, 4, 3, 5 }, 25));
        }
        public static long Solution(int[] nums, long k)
        {
            long count = 0;
            long sum = 0;
            long length = 0;
            long overflow = 0;
            long left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                length++;
                if (sum * length >= k)
                {
                    count += (length - 1) * (length - 1 + 1) / 2;
                    count -= (overflow) * (overflow + 1) / 2;
                    overflow = length - 1;
                }
                while (sum * length >= k)
                {
                    sum -= nums[left];
                    left++;
                    length--;
                    overflow--;
                }
            }
            count += (length) * (length + 1) / 2;
            count -= (overflow) * (overflow + 1) / 2;
            return count;
        }
    }
}

