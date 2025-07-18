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
            return Fib(n);
        }
        public static int Fib(int n)
        {
            if (n > 1)
            {
                return Fib(n - 1) + Fib(n - 2);
            }
            else if (n == 1) return 1;
            else if (n == 0) return 0;
            return 0;
        }
    }
}



