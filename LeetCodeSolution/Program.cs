namespace LeetCodeSolution
{
    class Program
    {
        // 25/05/2025 | 2131. Longest Palindrome by Concatenating Two Letter Words
        public static void Main()
        {
            Console.WriteLine(Solution(["ll", "lb", "bb", "bx", "xx", "lx", "xx", "lx", "ll", "xb", "bx", "lb", "bb", "lb", "bl", "bb", "bx", "xl", "lb", "xx"]));
        }

        public static int Solution(string[] words)
        {
            // 2 dictionary, 1 cai 2 tu khac nhau, 1 cai 2 tu giong nhau, 2 tu khac nhau ma chan => do dai mang, 2 tu giong nhau co so luong 1 => +2 vao mang, co so luong chan tu 2 => do dai mang.
            int count = 0;
            Dictionary<string, int> diffs = new Dictionary<string, int>();
            Dictionary<string, int> same = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (word[0] == word[1])
                {
                    if (same.ContainsKey(word))
                    {
                        same[word]++;
                    }
                    else same[word] = 1;
                }
                else
                {
                    if (diffs.ContainsKey(word))
                    {
                        diffs[word]++;
                    }
                    else diffs[word] = 1;
                }
            }
            var diffList = diffs.ToList();
            for (int i = 0; i < diffList.Count - 1; i++)
            {
                for (int j = i + 1; j < diffList.Count; j++)
                {
                    string word1 = diffList[i].Key;
                    string word2 = diffList[j].Key;
                    char[] arr = word2.ToCharArray();
                    Array.Reverse(arr);
                    word2 = new string(arr);
                    Console.WriteLine(word1);
                    Console.WriteLine(word2);
                    if (word1 == word2)
                    {
                        count += diffList[i].Value > diffList[j].Value ? diffList[j].Value * 4 : diffList[i].Value * 4;
                    }
                }
            }
            bool mid = false;
            foreach (var word in same)
            {
                if (!mid && word.Value % 2 != 0)
                {
                    mid = true;
                }
                if (word.Value >= 2)
                {
                    count += word.Value % 2 == 0 ? (word.Value) * 2 : (word.Value - 1) * 2;
                }
            }
            if (mid)
            {
                count += 2;
            }
            return count;
        }
    }
}

