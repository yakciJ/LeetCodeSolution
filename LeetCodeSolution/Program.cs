namespace LeetCodeSolution
{
    class Program
    {
        // 01/08/2025 | 118. Pascal's Triangle
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution(5)); // Example input  
            Console.WriteLine(Solution(1)); // Example input  
        }

        public static IList<IList<int>> Solution(int numRows)
        {
            List<IList<int>> rows = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else row.Add(rows[i - 1][j - 1] + rows[i - 1][j]);
                }
                rows.Add(row);
            }
            return rows;
        }
    }
}



