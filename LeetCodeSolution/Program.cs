namespace LeetCodeSolution
{
    class Program
    {
        // 24/05/2025 | 2942. Find Words Containing Character
        public static void Main()
        {
            Console.WriteLine(Solution(["leet", "code"], 'e'));
        }

        public static IList<int> Solution(string[] words, char x)
        {
            List<int> ints = new List<int>();
            //bool checkWord(string word)
            //{
            //    foreach (char chr in word)
            //    {
            //        if (chr == x)
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //}
            for (int i = 0; i < words.Length; i++)
            {
                {
                    if (words[i].Contains(x))
                    {
                        ints.Add(i);
                    }
                }
            }
            return ints;
        }
    }
}

