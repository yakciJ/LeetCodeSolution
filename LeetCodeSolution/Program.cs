namespace LeetCodeSolution
{
    class Program
    {
        // 08/07/2025 | 13. Roman to Integer

        public static void Main()
        {
            Console.WriteLine(Solution("III"));
        }
        // aaaaaaaaaaa
        public static int Solution(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I' && i < s.Length - 1 && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                {
                    sum--;
                }
                else if (s[i] == 'I') sum++;
                if (s[i] == 'V') sum += 5;
                if (s[i] == 'X' && i < s.Length - 1 && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                {
                    sum -= 10;
                }
                else if (s[i] == 'X') sum += 10;
                if (s[i] == 'L') sum += 50;
                if (s[i] == 'C' && i < s.Length - 1 && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                {
                    sum -= 100;
                }
                else if (s[i] == 'C') sum += 100;
                if (s[i] == 'D') sum += 500;
                if (s[i] == 'M') sum += 1000;
            }
            return sum;
        }
    }
}