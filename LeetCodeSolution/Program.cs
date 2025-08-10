namespace LeetCodeSolution
{
    class Program
    {
        // 10/08/2025 | 2108. Find First Palindromic String in the Array
        // ez
        // 
        public static void Main()
        {
            Console.WriteLine(Solution(["abc", "car", "ada", "racecar", "cool"]));
            Console.WriteLine(Solution(["notapalindrome", "racecar"]));
            Console.WriteLine(Solution(["po", "zsz"]));
        }

        public static string Solution(string[] words)
        {
            foreach (string word in words)
            {
                bool isPalindrome = true;
                int length = word.Length;
                for (int i = 0; i < word.Length / 2 + 1; i++)
                {
                    if (word[i] != word[length - i - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                {
                    return word;
                }
            }
            return "";
        }
    }
}



