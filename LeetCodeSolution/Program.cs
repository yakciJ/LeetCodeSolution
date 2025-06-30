namespace LeetCodeSolution
{
    class Program
    {
        // 30/6/2025 | 594. Longest Harmonious Subsequence

        public static void Main()
        {
            Console.WriteLine(Solution([1, 2, 2, 1]));
        }
        public static int Solution(int[] nums)
        {
            int maxLength = 0;
            Dictionary<int, int> freq = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (freq.ContainsKey(nums[i]))
                {
                    freq[nums[i]]++;
                }
                else freq[nums[i]] = 1;
            }
            foreach (var num in freq.Keys)
            {
                if (freq.ContainsKey(num + 1))
                {
                    maxLength = Math.Max(maxLength, freq[num] + freq[num + 1]);
                }
            }
            return maxLength;
        }
    }
}