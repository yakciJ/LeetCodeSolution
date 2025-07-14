namespace LeetCodeSolution
{
    class Program
    {
        // 14/07/2025 | 409. Longest Palindrome
        // ez

        public static void Main()
        {
            //Console.WriteLine(Solution([1, 0, 1]);
        }
        // greedy
        public static int Solution(string s)
        {
            int res = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else dict[s[i]] = 1;
                if (dict[s[i]] % 2 == 0)
                {
                    res += 2;
                }
            }
            //foreach(var val in dict.Values)
            //{
            //    if (val % 2 == 0)
            //    {
            //        res += val;
            //    }
            //    else res += val - 1;
            //}
            if(res % 2 == 0 && res < s.Length)
            {
                res++;
            }
            return res;
        }
    }
}