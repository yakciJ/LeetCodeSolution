namespace LeetCodeSolution
{
    class Program
    {
        // 1/7/2025 | 3330. Find the Original Typed String I

        public static void Main()
        {
            Console.WriteLine(Solution("abbcccc"));
        }
        public static int Solution(string word)
        {
            int total = 1;
            int count = 0;
            char present = word[0];
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == present)
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    {
                        total += count;
                    }
                    present = word[i];
                    count = 0;
                }
            }
            if (count > 0)
            {
                total += count;
            }
            return total;
        }
    }
}