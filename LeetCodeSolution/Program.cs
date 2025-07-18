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
            int one = 0;
            int two = 0;
            int three = 1;

            if (n < 2)
            {
                return n;
            }
            for (int i = 2; i <= n; i++)
            {
                one = two + three;
                two = three;
                three = one;
            }
            return one;
        }
    }
}



