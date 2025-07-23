namespace LeetCodeSolution
{
    class Program
    {
        // 23/07/2025 | 1717. Maximum Score From Removing Substrings
        // med
        public static void Main()
        {
            Console.WriteLine(Solution("cdbcbbaaabab", 4, 5)); // Example input  
            Console.WriteLine(Solution("aabbaaxybbaabb", 5, 4)); // Example input  
        }

        public static int Solution(string s, int x, int y)
        {
            char a, b;
            int score = 0;
            int score1 = x > y ? x : y;
            if (x > y)
            {
                a = 'a';
                b = 'b';
            }
            else
            {
                a = 'b';
                b = 'a';
            }
            Stack<char> chars = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (chars.Count > 0 && s[i] == b && chars.Peek() == a)
                {
                    score += score1;
                    chars.Pop();
                }
                else chars.Push(s[i]);
            }
            score1 = x < y ? x : y;
            var remaining = new string(chars.Reverse().ToArray());
            chars = new Stack<char>();
            for (int i = 0; i < remaining.Length; i++)
            {
                if (chars.Count > 0 && remaining[i] == a && chars.Peek() == b)
                {
                    score += score1;
                    chars.Pop();
                }
                else chars.Push(remaining[i]);
            }
            return score;
        }
    }
}



