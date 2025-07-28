namespace LeetCodeSolution
{
    class Program
    {
        // 28/07/2025 | 2044. Count Number of Maximum Bitwise-OR Subsets
        // med
        public static void Main()
        {
            Console.WriteLine(Solution([2, 4, 1, 1, 6, 5])); // Example input  
            Console.WriteLine(Solution([6, 6, 5, 5, 4, 1])); // Example input  
        }

        public static int Solution(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                max |= nums[i];
            }
            int count = 0;
            void BackTracking(int start, int sum)
            {
                for (int i = start; i < nums.Length; i++)
                {
                    int newSum = sum | nums[i];
                    if (newSum == max)
                    {
                        count++;
                    }
                    BackTracking(i + 1, newSum);
                }
            }
            BackTracking(0, 0);
            return count;
        }
    }
}



