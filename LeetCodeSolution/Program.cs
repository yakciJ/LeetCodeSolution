namespace LeetCodeSolution
{
    class Program
    {
        // 26/07/2025 | 27. Remove Element
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution([3, 2, 2, 3], 3)); // Example input  
            Console.WriteLine(Solution([0, 1, 2, 2, 3, 0, 4, 2], 2)); // Example input  
        }

        public static int Solution(int[] nums, int val)
        {
            int i = 0, j = 0;
            while (j < nums.Length)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
                j++;
            }
            return i;
        }
    }
}



