namespace LeetCodeSolution
{
    class Program
    {
        // 13/08/2025 | 326. Power of Three
        // ez
        // lam ez de danh thoi gian cho prj
        public static void Main()
        {
            Console.WriteLine(Solution(27));
            Console.WriteLine(Solution(0));
            Console.WriteLine(Solution(-1));
        }

        public static bool Solution(int n)
        {
            if (n < 1)
            {
                return false;
            }
            while (n % 3 == 0)
            {
                n = n / 3;
            }
            return n == 1;
            //if (n == 1)
            //{
            //    return true;
            //}
            //double a = n;
            //while (a > 1)
            //{
            //    if ((a /= 3) == 1) return true;
            //}
            //return false;
        }
        // còn 1 cách nữa là lớn hơn 0, và chia hết cho số mũ lớn nhất của 3 trong int, nghĩa là 1162261467 % n == 0;
    }
}



