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
            List<int> res = new List<int>();
            int min = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == key)
                {
                    int start = Math.Max(min, i - k);
                    int end = Math.Min(i + k, nums.Length - 1); 
                    for(int j = start; j <= end; j++)
                    {
                        res.Add(j);
                    }
                    min = i + k + 1;
                }
            }
            return res;
        }
    }
}