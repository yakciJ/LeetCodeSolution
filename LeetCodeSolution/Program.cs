namespace LeetCodeSolution
{
    class Program
    {
        // 22/07/2025 | 1695. Maximum Erasure Value
        // med
        public static void Main()
        {
            Console.WriteLine(Solution([4, 2, 4, 5, 6])); // Example input  
            Console.WriteLine(Solution([5, 2, 1, 2, 5, 2, 1, 2, 5])); // Example input  
        }

        public static int Solution(int[] nums)
        {
            var unique = new HashSet<int>();
            int sum = nums[0];
            int max = nums[0];
            int i = 0, j = 1;
            unique.Add(nums[0]);
            while (j < nums.Length)
            {
                while (!unique.Add(nums[j]))
                {
                    sum -= nums[i];
                    unique.Remove(nums[i]);
                    i++;
                }
                sum += nums[j];
                if (sum > max) max = sum;
                j++;
            }
            return max;
        }
    }
}



