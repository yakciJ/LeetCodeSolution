namespace LeetCodeSolution
{
    class Program
    {
        // 08/07/2025 | 9. Palindrome Number

        public static void Main()
        {
            Console.WriteLine(Solution(121));
        }
        // aaaaaaaaaaa
        public static bool Solution(int x)
        {
            string a = x.ToString();
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}