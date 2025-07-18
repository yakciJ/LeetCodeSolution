namespace LeetCodeSolution
{
    class Program
    {
        // 18/07/2025 | 509. Fibonacci Number
        // ez 

        public static void Main()
        {
            Console.WriteLine(Solution(10)); // Example input  
        }
        //  hoc ve de quy recursion
        public static int Solution(int n)
        {
            int[] memo = new int[n + 1];
            return Fib(n, memo);
        }
        public static int Fib(int n, int[] memo)
        {
            if (n <= 1)
            {
                return n;
            }
            if (memo[n] != 0)
            {
                return memo[n];
            }
            memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
            return memo[n];
        }
    }
}



