namespace LeetCodeSolution
{
    class Program
    {
        // 08/08/2025 | 2639. Find the Width of Columns of a Grid
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution([[1], [22], [333]]));
            Console.WriteLine(Solution([[-15, 1, 3], [15, 7, 12], [5, 6, -2]]));
            //Console.WriteLine(Solution([-1, -2, -3]));
        }

        public static int[] Solution(int[][] grid)
        {
            int[] ans = new int[grid[0].Length];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    int temp = grid[i][j];
                    int count = 0;
                    if (temp <= 0)
                    {
                        count++;
                        temp *= -1;
                    }
                    while (temp > 0)
                    {
                        temp /= 10;
                        count++;
                    }
                    if (ans[j] < count) ans[j] = count;
                }
            }
            return ans;
        }
    }
}



