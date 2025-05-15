namespace LeetCodeSolution
{
    class Program
    {
        // 15/05/2025 | 2900. Longest Unequal Adjacent Groups Subsequence I
        public static void Main()
        {
            Console.WriteLine(Solution(["e", "a", "b"], [0, 0, 1]));
        }

        public static IList<string> Solution(string[] words, int[] groups)
        {
            IList<string> arr = new List<string>();
            int a = groups[0];
            arr.Add(words[0]);
            for (int i = 0; i < words.Length; i++)
            {
                if (groups[i] != a)
                {
                    arr.Add(words[i]);
                    a = groups[i] == 0 ? 0 : 1;
                }
            }
            
            return arr;
        }
    }
}

