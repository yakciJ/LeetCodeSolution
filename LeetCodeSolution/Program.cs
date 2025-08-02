namespace LeetCodeSolution
{
    class Program
    {
        // 02/08/2025 | 3158. Find the XOR of Numbers Which Appear Twice
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution([1, 2, 1, 3])); // Example input  
            Console.WriteLine(Solution([1, 2, 2, 1])); // Example input  
        }

        public static int Solution(int[] nums)
        {
            int sum = 0;
            int[] freq = new int[51];
            foreach (int x in nums)
            {
                freq[x]++;
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] == 2)
                {
                    sum ^= i;
                }
            }
            return sum;
        }
    }
}



