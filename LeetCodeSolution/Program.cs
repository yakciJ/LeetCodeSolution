namespace LeetCodeSolution
{
    class Program
    {
        // 03/08/2025 | 2609. Find the Longest Balanced Substring of a Binary String
        // ez
        public static void Main()
        {
            //Console.WriteLine(Solution("01000111")); // Example input  
            //Console.WriteLine(Solution("00111")); // Example input  
            Console.WriteLine(Solution("101001000000000011110000000011111111111111")); // Example input  
        }

        public static int Solution(string s)
        {
            int max = 0;
            int countZero = 0;
            int countOne = 0;
            bool zeroFirst = false;
            bool oneAfter = false;
            foreach (char c in s)
            {
                if (c == '0')
                {
                    if (oneAfter)
                    {
                        max = Math.Max(max, Math.Min(countOne, countZero) * 2);
                        oneAfter = false;
                        countOne = 0;
                        countZero = 0;
                    }
                    countZero++;
                    zeroFirst = true;
                }
                else if (zeroFirst)
                {
                    countOne++;
                    if (zeroFirst) oneAfter = true;
                }
            }
            if (oneAfter)
            {
                max = Math.Max(max, Math.Min(countOne, countZero) * 2);
                oneAfter = false;
                countOne = 0;
                countZero = 0;
            }
            return max;
        }
    }
}



