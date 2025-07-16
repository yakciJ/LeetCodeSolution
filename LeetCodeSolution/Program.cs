namespace LeetCodeSolution
{
    class Program
    {
        // 16/07/2025 | 704. Binary Search
        // ez 

        public static void Main()
        {
            Console.WriteLine(Solution([5], 5)); // Example input  
        }
        //  hoc ve binary search
        public static int Solution(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int middle = ((end - start) / 2) + start;
                if (nums[middle] == target)
                {
                    return middle;
                }
                else if (nums[middle] < target)
                {
                    start = middle + 1;
                }
                else end = middle - 1;
            }
            return -1;
        }
    }
}
