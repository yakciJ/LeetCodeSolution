namespace LeetCodeSolution
{
    class Program
    {
        // 18/07/2025 | 70. Climbing Stairs
        // ez 

        public static void Main()
        {
            Console.WriteLine(Solution(10)); // Example input  
        }
        //  hoc ve dp
        public static int Solution(int n)
        {
            int[] ans = new int[n + 1];
            ans[0] = 1;
            ans[1] = 2;
            if (n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    ans[i] = ans[i - 1] + ans[i - 2];
                }
            }
            return ans[n - 1];
        }
    }
}



