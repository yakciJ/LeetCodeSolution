namespace LeetCodeSolution
{
    class Program
    {
        // 19/05/2025 | 3024. Type of Triangle
        public static void Main()
        {
            Console.WriteLine(Solution([3, 3, 3]));
        }

        public static string Solution(int[] nums)
        {
            bool sort = true;
            while (sort)
            {
                sort = false;
                for (int i = 0; i < nums.Length - 1; i++)
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
            string[] types = { "equilateral", "isosceles", "scalene", "none" };
            //Array.Sort(nums);
            if (nums[2] < nums[0] + nums[1])
            {
                if (nums[2] == nums[0]) return types[0];
                if (nums[0] == nums[1] || nums[1] == nums[2]) return types[1];
                return types[2];
            }
            return types[3];
        }
    }
}

