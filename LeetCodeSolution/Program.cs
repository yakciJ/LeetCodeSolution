namespace LeetCodeSolution
{
    class Program
    {
        // 21/07/2025 | 1957. Delete Characters to Make Fancy String
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution("leeetcode")); // Example input  
        }

        public static string Solution(string s)
        {
            char[] res = new char[s.Length];
            int index = 0;
            int count = 0;
            char cur = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == cur)
                {
                    count++;
                }
                else
                {
                    cur = s[i];
                    count = 1;
                }
                if (count < 3)
                {
                    res[index++] = s[i];
                }
            }
            return new string(res, 0, index);
        }
    }
}



