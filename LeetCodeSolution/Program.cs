namespace LeetCodeSolution
{
    class Program
    {
        // 05/08/2025 | 3477. Fruits Into Baskets II
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution([4, 2, 5], [3, 5, 4]));
            Console.WriteLine(Solution([3, 6, 1], [6, 4, 7]));
            //Console.WriteLine(Solution([1, 2, 3, 2, 2]));
        }

        public static int Solution(int[] fruits, int[] baskets)
        {
            int count = 0;
            foreach (var fruit in fruits)
            {
                for (int j = 0; j < baskets.Length; j++)
                {
                    if (baskets[j] >= fruit)
                    {
                        count++;
                        baskets[j] = 0;
                        break;
                    }
                }
            }
            return fruits.Length - count;
        }
    }
}



