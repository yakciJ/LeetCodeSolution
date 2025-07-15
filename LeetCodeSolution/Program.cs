namespace LeetCodeSolution
{
    class Program
    {
        // 15/07/2025 | 3136. Valid Word        
        // ez  

        public static void Main()
        {
            Console.WriteLine(Solution("234Adas")); // Example input  
        }
        //   
        public static bool Solution(string word)
        {
            List<char> myList = new List<char>() { 'u', 'e', 'o', 'a', 'i', 'U', 'E', 'O', 'A', 'I' };
            bool vowel = false;
            bool consonant = false;
            if (word.Length < 3)
            {
                return false;
            }
            else
            {
                foreach (char c in word)
                {
                    if (c < '0' || c > 'z' || (c > '9' && c < 'A') || (c > 'Z' && c < 'a'))
                    {
                        return false;
                    }
                    if (!vowel)
                    {
                        if (myList.Contains(c))
                        {
                            vowel = true;
                        }
                    }
                    if (!consonant)
                    {
                        if (!myList.Contains(c) && char.IsLetter(c))
                        {
                            consonant = true;
                        }
                    }
                }
            }
            return vowel && consonant;
        }
    }
}
