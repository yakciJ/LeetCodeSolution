namespace LeetCodeSolution
{
    class Program
    {
        // 25/6/2025 | 2040. Kth Smallest Product of Two Sorted Arrays

        public static void Main()
        {
            Console.WriteLine(Solution([-2, -1, 0, 1, 2], [-3, -1, 2, 4, 5], 3));
        }
        public static long Solution(int[] nums1, int[] nums2, long k)
        {
            long right = 10000000000L;
            long left = -10000000000L;
            while (left < right)
            {
                long mid = left + (right - left) / 2;
                long count = 0;
                for (int i = 0; i < nums1.Length; i++)
                {
                    if (nums1[i] > 0)
                    {
                        long limit = (long)Math.Floor((double)mid / nums1[i]);
                        long c = CountLessThanOrEqual(nums2, limit);
                        count += c;
                    }
                    else if (nums1[i] < 0)
                    {
                        long limit = (long)Math.Ceiling((double)mid / nums1[i]);
                        long c = CountGreaterThanOrEqual(nums2, limit);
                        count += c;
                    }
                    else if (nums1[i] == 0)
                    {
                        if (mid >= 0)
                            count += nums2.Length;
                    }
                }
                if (count >= k)
                {
                    right = mid;
                }
                else left = mid + 1;
            }
            return left;
        }
        public static long CountGreaterThanOrEqual(int[] nums, long limit)
        {
            int max = nums.Length;
            int min = 0;
            while (min < max)
            {
                int mid = (max + min) / 2;
                if (nums[mid] < limit)
                {
                    min = mid + 1;
                }
                else max = mid;
            }
            int count = nums.Length - min;
            return count;
        }
        public static long CountLessThanOrEqual(int[] nums, long limit)
        {
            int max = nums.Length;
            int min = 0;
            while (min < max)
            {
                int mid = (max + min) / 2;
                if (nums[mid] <= limit)
                {
                    min = mid + 1;
                }
                else max = mid;
            }
            return min;
        }
    }
}