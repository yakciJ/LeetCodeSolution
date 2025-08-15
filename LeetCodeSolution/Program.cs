namespace LeetCodeSolution
{
    class Program
    {
        // 15/08/2025 | 342. Power of Four
        // ez
        // lam ez de danh thoi gian cho prj
        public static void Main()
        {
            Console.WriteLine(Solution(16));
            Console.WriteLine(Solution(5));
            Console.WriteLine(Solution(1));
        }

        public static bool Solution(int n)
        {
            if (n == 1)
            {
                return true;
            }
            double a = n;
            while (a > 1)
            {
                if ((a /= 4) == 1) return true;
            }
            return false;
        }
    }
}



