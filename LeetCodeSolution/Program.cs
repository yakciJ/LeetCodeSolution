namespace LeetCodeSolution
{
    class Program
    {
        // 24/07/2025 | 3110. Score of a String
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution("hello")); // Example input  
            Console.WriteLine(Solution("asdasdwfcvqwescxzcergtasd")); // Example input  
        }

        public static int Solution(string s)
        {
            int score = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                score += Math.Abs(s[i] - s[i + 1]);
            }
            return score;
        }
    }
}



