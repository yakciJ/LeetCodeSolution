namespace LeetCodeSolution
{
    class Program
    {
        // 09/07/2025 | 20. Valid Parentheses

        public static void Main()
        {
            Console.WriteLine(Solution("()"));
        }
        // dung stack
        public static bool Solution(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{') stack.Push(c);
                else if (c == ')' && stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack.Count > 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (c == '}' && stack.Count > 0 && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else return false;
            }
            if(stack.Count > 0) return false;
            return true;
        }
    }
}