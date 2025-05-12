namespace LeetCodeSolution
{
    class Program
    {
        // 11/05/2025 | 1550. Three Consecutive Odds
        public static void Main()
        {
            int[] digits = { 2, 6, 4, 1 };
            Console.WriteLine(Solution(digits));
        }

        public static bool Solution(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
                else count = 0;
                if (count == 3) return true;
            }
            return false;
        }
    }
}

