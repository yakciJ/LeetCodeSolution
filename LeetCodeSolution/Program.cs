namespace LeetCodeSolution
{
    class Program
    {
        // 11/07/2025 | 26. Remove Duplicates from Sorted Array

        public static void Main()
        {
            Console.WriteLine(Solution([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]));
        }
        // dung two pointers

        public static int Solution(int[] nums)
        {
            int k = 1;
            int current = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != current)
                {
                    nums[k] = nums[i];
                    current = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}