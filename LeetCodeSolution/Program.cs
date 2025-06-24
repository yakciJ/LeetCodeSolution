namespace LeetCodeSolution
{
    class Program
    {
        // 24/6/2025 | 2200. Find All K-Distant Indices in an Array

        public static void Main()
        {
            Console.WriteLine(Solution([3, 4, 9, 1, 3, 9, 5], 9, 1));
        }
        public static IList<int> Solution(int[] nums, int key, int k)
        {
            HashSet<int> set = new HashSet<int>();
            void addToHash(int start, int end)
            {
                if(end >= nums.Length) end = nums.Length - 1;
                if(start < 0) start = 0;
                for (int i = start; i <= end; i++)
                {
                    set.Add(i);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == key)
                {
                    addToHash(i - k, i + k);
                }
            }
            IList<int> list = [.. set];
            return list;
        }
    }
}