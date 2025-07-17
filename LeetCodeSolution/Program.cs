namespace LeetCodeSolution
{
    class Program
    {
        // 17/07/2025 | 338. Counting Bits
        // ez 

        public static void Main()
        {
            Console.WriteLine(Solution(10)); // Example input  
        }
        //  hoc ve dp
        public static int[] Solution(int n)
        {
            int[] ans = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                ans[i] = ans[i >> 1] + (i & 1);
            }
            return ans;
        }
    }
}



