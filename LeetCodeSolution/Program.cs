namespace LeetCodeSolution
{
    class Program
    {
        // 12/07/2025 | 14. Longest Common Prefix
        // ez

        public static void Main()
        {
            Console.WriteLine(Solution(["flower", "flow", "flight"]));
        }
        // 

        public static string Solution(string[] strs)
        {
            int k = strs[0].Length;
            for (int i = 1; i < strs.Length; i++)
            {
                k = k >= strs[i].Length ? strs[i].Length : k;
                for (int j = 0; j < k; j++)
                {
                    if (strs[i][j] != strs[0][j])
                    {
                        k = j;
                        break;
                    }
                }
                if (k == 0)
                {
                    return "";
                }
            }
            string res = "";
            for (int i = 0; i < k; i++)
            {
                res += strs[0][i];
            }
            return res;
        }
    }
}