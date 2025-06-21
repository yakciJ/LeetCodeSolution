namespace LeetCodeSolution
{
    class Program
    {
        // 21/6/2025 | 3085. Minimum Deletions to Make String K-Special

        public static void Main()
        {
            Console.WriteLine(Solution("aabcaba", 0));
        }

        public static int Solution(string word, int k)
        {
            int steps = int.MaxValue;
            int[] chars = new int[26];
            for (int i = 0; i < word.Length; i++)
            {
                chars[word[i] - 'a']++;
            }
            var nonZero = chars.Where(x => x > 0).ToArray();
            foreach (var freq in nonZero)
            {
                int tempSteps = 0;
                foreach (var x in nonZero)
                {
                    if (x > freq + k)
                    {
                        tempSteps += x - (freq + k);
                    }
                    else if (x < freq - k)
                    {
                        tempSteps += x;
                    }
                }
                if (tempSteps < steps) steps = tempSteps;
            }
            return steps;
        }
    }
}

