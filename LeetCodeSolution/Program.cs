namespace LeetCodeSolution
{
    class Program
    {
        // 19/6/2025 | 2294. Partition Array Such That Maximum Difference Is K
        public static void Main()
        {
            Console.WriteLine(Solution([3, 6, 1, 2, 5], 2));
        }

        public static int Solution(int[] nums, int k)
        {
            // giong bai hom qua vl, con de hon
            int count = 0;
            Array.Sort(nums);
            int min = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] - min > k)
                {
                    min = nums[i];
                    count++;
                }
            }
            count++;
            return count;
        }
    }
}

