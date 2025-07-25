namespace LeetCodeSolution
{
    class Program
    {
        // 25/07/2025 | 3487. Maximum Unique Subarray Sum After Deletion
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution([-1])); // Example input  
            Console.WriteLine(Solution([1, 2, -1, -2, 1, 0, -1])); // Example input  
        }

        public static int Solution(int[] nums)
        {
            int sum = 0;
            bool[] unique = new bool[201];
            int j = 0;
            int max = -101;
            while (j < nums.Length)
            {
                if (nums[j] > 0 && unique[nums[j] + 100] == false)
                {
                    sum += nums[j];
                    unique[nums[j] + 100] = true;
                }
                max = Math.Max(nums[j], max);
                j++;
            }
            if (max < 0)
            {
                return max;
            }
            return sum;
        }
    }
}



