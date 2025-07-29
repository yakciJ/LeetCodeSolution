
namespace LeetCodeSolution
{
    class Program
    {
        // 29/07/2025 | 2411. Smallest Subarrays With Maximum Bitwise OR
        // hpbd
        // med
        public static void Main()
        {
            Console.WriteLine(Solution([1, 0, 2, 1, 3])); // Example input  
            Console.WriteLine(Solution([1, 2])); // Example input  
        }

        public static int[] Solution(int[] nums)
        {
            int[] lastSeen = new int[31];
            for (int i = 0; i < 31; i++)
            {
                lastSeen[i] = -1;
            }
            int[] res = new int[nums.Length];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < 31; j++)
                {
                    if (((nums[i] >> j) & 1) == 1)
                    {
                        lastSeen[j] = i;
                    }
                }
                int max = i;
                for (int j = 0; j < 31; j++)
                {
                    if (lastSeen[j] != -1)
                    {
                        max = Math.Max(max, lastSeen[j]);
                    }
                }
                res[i] = max - i + 1;
            }
            return res;
        }
    }
}



