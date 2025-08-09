namespace LeetCodeSolution
{
    class Program
    {
        // 09/08/2025 | 231. Power of Two
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution(1));
            Console.WriteLine(Solution(16));
            Console.WriteLine(Solution(3));
        }

        public static bool Solution(int n)
        {
            return (n > 0 && (n & (n - 1)) == 0);
            // giải thích: mũ 2 luôn luôn chỉ có 1 bit 1, nghĩa là vd: 8 = 1000, 2 = 10, .... nên n - 1 sẽ biến toàn bộ bit sau số 1 duy nhất đó thành 1 và số 1 đó sẽ thành số 0, 7 = 0111, 1 = 1, nên n & (n-1), & là cả 2 bit = 1 thì mới = 1, nên 1000 với 0111 thì sẽ thành 0000 = 0.
        }
    }
}



