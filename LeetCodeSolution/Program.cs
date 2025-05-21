namespace LeetCodeSolution
{
    class Program
    {
        // 21/05/2025 | 73. Set Matrix Zeroes
        public static void Main()
        {
            Solution([[1, 2, 3, 4], [5, 0, 7, 8], [0, 10, 11, 12], [13, 14, 15, 0]]);
        }

        public static void Solution(int[][] matrix)
        {
            int[] rows = new int[matrix.Length];
            int[] columns = new int[matrix[0].Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows[i] = 1;
                        columns[j] = 1;
                    }
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (rows[i] == 1 || columns[j] == 1)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}

