namespace LeetCodeSolution
{
    class Program
    {
        // 05/08/2025 | 2309. Greatest English Letter in Upper and Lower Case
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution("lEeTcOdE"));
            Console.WriteLine(Solution("arRAzFif"));
            Console.WriteLine(Solution("AbCdEfGhIjK"));
        }

        public static string Solution(string s)
        {
            bool[] nor = new bool[26];
            bool[] upper = new bool[26];
            string a = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    upper[s[i] - 'A'] = true;
                }
                else
                {
                    nor[s[i] - 'a'] = true;
                }
            }
            for (int i = 25; i >= 0; i--)
            {
                if (nor[i] == true && upper[i] == true)
                {
                    a = ((char)('A' + i)).ToString();
                    return a;
                }
            }
            return a;
        }
    }
}



