
namespace LeetCodeSolution
{
    class Program
    {
        // 30/07/2025 | 2419. Longest Subarray With Maximum Bitwise AND
        // med
        public static void Main()
        {
            Console.WriteLine(Solution([1, 2, 3, 3, 2, 2])); // Example input  
            Console.WriteLine(Solution([1, 2, 3, 4])); // Example input  
        }

        public static int Solution(int[] nums)
        {
            int maxCount = 1;
            int count = 0;
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    count = 1;
                    maxCount = 1;
                }
                else if (nums[i] == max)
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else count = 0;
            }
            return maxCount;
        }
    }
}



