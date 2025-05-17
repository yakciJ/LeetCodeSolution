namespace LeetCodeSolution
{
    class Program
    {
        // 16/05/2025 | 75. Sort Colors
        public static void Main()
        {
            //Console.WriteLine(Solution([0, 0, 1]));
        }

        public static void Solution(int[] nums)
        {
            bool sort = true;
            while (sort)
            {
                sort = false;
                for(int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                        sort = true;
                    }
                }
            }
        }
    }
}

