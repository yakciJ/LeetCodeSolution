namespace LeetCodeSolution
{
    class Program
    {
        // 03/08/2025 | 896. Monotonic Array
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution([1, 2, 2, 3])); // Example input  
            Console.WriteLine(Solution([6, 5, 4, 4])); // Example input  
            Console.WriteLine(Solution([1, 3, 2])); // Example input  
        }

        public static bool Solution(int[] nums)
        {
            string status = null;
            if (nums.Length == 1) return true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (status == null && nums[i] < nums[i + 1])
                {
                    status = "increasing";
                }
                else if (status == null && nums[i] > nums[i + 1])
                {
                    status = "decreasing";
                }
                if (nums[i] < nums[i + 1] && status == "decreasing")
                {
                    return false;
                }
                else if (nums[i] > nums[i + 1] && status == "increasing")
                {
                    return false;
                }
            }
            return true;
        }
    }
}



