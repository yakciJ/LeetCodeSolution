namespace LeetCodeSolution
{
    class Program
    {
        // 21/05/2025 | 73. Set Matrix Zeroes
        public static void Main()
        {
            Solution([[1, 1, 1], [1, 0, 1], [1, 1, 1]]);
        }

        public static void Solution(int[][] matrix)
        {
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> columns = new HashSet<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (!rows.Contains(i))
                        {
                            rows.Add(i);
                        }
                        if (!columns.Contains(j))
                        {
                            columns.Add(j);
                        }
                        columns.Add(j);
                    }
                    else if (rows.Contains(i) || columns.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[0].Length; j++)
                {
                    if(rows.Contains(i) || columns.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}

