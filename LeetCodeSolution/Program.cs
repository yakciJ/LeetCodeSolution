namespace LeetCodeSolution
{
    class Program
    {
        // 14/07/2025 | 409. Longest Palindrome
        // ez

        public static void Main()
        {
            Console.WriteLine(Solution([1, 0, 1, 0, 1, 0, 1], 1));
        }
        // greedy
        public static bool Solution(int[] flowerbed, int n)
        {
            int empty = 0;
            if (flowerbed.Length > 4)
            {
                if (flowerbed[0] == 0 && flowerbed[1] == 0)
                {
                    flowerbed[0] = 1;
                    empty = 1;
                }
                for (int i = 1; i < flowerbed.Length - 1; i++)
                {
                    if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0 && flowerbed[i] == 0)
                    {
                        flowerbed[i] = 1;
                        empty++;
                    }
                }
                if (flowerbed[flowerbed.Length - 1] == 0 && flowerbed[flowerbed.Length - 2] == 0)
                {
                    empty++;
                }
            }
            else if (flowerbed.Length >= 3)
            {
                if (flowerbed[0] == 0 && flowerbed[1] == 0)
                {
                    empty++;
                }
                if (flowerbed[flowerbed.Length - 1] == 0 && flowerbed[flowerbed.Length - 2] == 0)
                {
                    empty++;
                }
            }
            else if (flowerbed.Length == 2)
            {
                if (flowerbed[0] == 0 && flowerbed[1] == 0)
                {
                    empty++;
                }
            }
            else if (flowerbed[0] == 0)
            {
                empty++;
            }
            if (empty >= n) return true;
            else return false;
        }
    }
}