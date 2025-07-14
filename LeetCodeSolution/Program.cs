namespace LeetCodeSolution
{
    class Program
    {
        // 14/07/2025 | 561. Array Partition
        // ez

        public static void Main()
        {
            Console.WriteLine(Solution([1, 4, 3, 2]));
        }
        // greedy
        public static int Solution(int[] nums)
        {
            int res = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i += 2)
            {
                res += nums[i];
            }
            return res;
        }
    }
}