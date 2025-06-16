namespace LeetCodeSolution
{
    class Program
    {
        // 16/6/2025 | 2016. Maximum Difference Between Increasing Elements
        public static void Main()
        {
            Console.WriteLine(Solution([7, 1, 5, 4]));
        }

        public static int Solution(int[] nums)
        {
            int diff = -1;
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                if (nums[i] != min)
                {
                    diff = Math.Max(diff, nums[i] - min);
                }
            }
            return diff;
        }
    }
}

