namespace LeetCodeSolution
{
    class Program
    {
        // 06/08/2025 | 2299. Strong Password Checker II
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution("IloveLe3tcode!"));
            Console.WriteLine(Solution("Me+You--IsMyDream"));
            Console.WriteLine(Solution("1aB!"));
        }

        public static bool Solution(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            bool LowerCase = false;
            bool UpperCase = false;
            bool Digit = false;
            bool SpecialChar = false;
            char before = '.';
            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];
                if (ch == before)
                {
                    return false;
                }
                else before = ch;
                if (char.IsDigit(ch))
                {
                    Digit = true;
                }
                if (char.IsUpper(ch))
                {
                    UpperCase = true;
                }
                if (char.IsLower(ch))
                {
                    LowerCase = true;
                }
                if (!char.IsLetterOrDigit(ch))
                {
                    SpecialChar = true;
                }
            }
            if (LowerCase == false || UpperCase == false || Digit == false || SpecialChar == false)
            {
                return false;
            }
            return true;
        }
    }
}



