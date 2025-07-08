namespace LeetCodeSolution
{
    class Program
    {
        // 08/07/2025 | 1. Two Sum

        public static void Main()
        {
            Console.WriteLine(Solution([3, 2, 4], 6));
        }
        // aaaaaaaaaaa
        public static int[] Solution(int[] nums, int target)
        {
            Dictionary<int, int> index = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (index.Count > 0 && index.ContainsKey(target - nums[i]))
                {
                    return [index[target - nums[i]], i];
                }
                if (!index.ContainsKey(nums[i]))
                {
                    index.Add(nums[i], i);
                }
            }
            return [0, 0];
        }
    }
}