namespace LeetCodeSolution
{
    class Program
    {
        // 03/07/2025 | 3304. Find the K-th Character in String Game I

        public static void Main()
        {
            Console.WriteLine(Solution(5));
        }
        public static char Solution(int k)
        {
            string word = "a";
            while (word.Length < k)
            {
                string temp = "";
                for (int i = 0; i < word.Length; i++)
                {
                    temp += (char)(word[i] + 1);
                }
                word += temp;
            }
            return word[k - 1];
        }
    }
}