namespace LeetCodeSolution
{
    class Program
    {
        // 28/6/2025 | 2099. Find Subsequence of Length K With the Largest Sum

        public static void Main()
        {
            Console.WriteLine(Solution([3, 4, 3, 3], 2));
        }
        public static int[] Solution(int[] nums, int k)
        {
            int[] res = new int[k];
            var paired = nums.Select((value, index) => (value, index)).ToList();
            paired.Sort((a, b) => b.value.CompareTo(a.value));
            int[] topKIndices = paired.Select(p => p.index).Take(k).ToArray();
            Array.Sort(topKIndices);
            for (int i = 0; i < k; i++)
            {
                res[i] = nums[topKIndices[i]];
            }
            return res;
        }
    }
}