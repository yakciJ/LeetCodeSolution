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
            Dictionary<char, int> RomanNums = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && RomanNums[s[i]] < RomanNums[s[i + 1]])
                {
                    sum -= RomanNums[s[i]];
                }
                else sum += RomanNums[s[i]];
            }
            return sum;
        }
    }
}