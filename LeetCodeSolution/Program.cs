namespace LeetCodeSolution
{
    class Program
    {
        // 21/6/2025 | 3085. Minimum Deletions to Make String K-Special

        public static void Main()
        {
            Console.WriteLine(Solution("ctoyjrwtngqwt", 8, 'n'));
        }

        public static string[] Solution(string s, int k, char fill)
        {
            int length = (int)Math.Ceiling((double)s.Length / k);
            string[] arr = new string[length];
            int x = 0;
            string temp = string.Empty;
            int y = 0;
            for (int i = 0; i < s.Length; i++)
            {
                temp += s[i];
                x++;
                if (x == k || i == s.Length - 1)
                {
                    x = 0;
                    arr[y] = temp;
                    temp = string.Empty;
                    y++;
                }
            }
            if (arr[length - 1].Length != k)
            {
                int n = k - arr[length - 1].Length;
                for (int i = 0; i < n; i++)
                {
                    arr[length - 1] += fill;
                }
            }
            return arr;
        }
    }
}

