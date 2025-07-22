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
            var unique = new bool[10001];
            int sum = nums[0];
            int max = nums[0];
            int i = 0, j = 1;
            unique[nums[0]] = true;
            while (j < nums.Length)
            {
                while (unique[nums[j]] == true)
                {
                    sum -= nums[i];
                    unique[nums[i]] = false;
                    i++;
                }
                unique[nums[j]] = true;
                sum += nums[j];
                if (sum > max) max = sum;
                j++;
            }
            return max;
        }
    }
}



