namespace LeetCodeSolution
{
    class Program
    {
        // 08/08/2025 | 2855. Minimum Right Shifts to Sort the Array
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution([3, 4, 5, 1, 2]));
            Console.WriteLine(Solution([31, 72, 79, 25]));
            Console.WriteLine(Solution([2, 1, 4]));
        }

        public static int Solution(IList<int> nums)
        {
            int res = -2;
            bool only = false;
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    if (only)
                    {
                        return -1;
                    }
                    res = i;
                    only = true;
                }
            }
            if (nums[nums.Count - 1] > nums[0] && only)
            {
                return -1;
            }
            if (res == -2)
            {
                return 0;
            }
            return nums.Count - res - 1;
        }
    }
}



