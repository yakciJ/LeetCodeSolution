namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 18/4/2025
        public static void Main()
        {
            Console.WriteLine(CountAndSay(4));
        }
        public static string CountAndSay(int n)
        {
            string S = "1";
            int count = 1;
            if (n == 1)
            {
                return S;
            }
            for (int i = 1; i < n; i++)
            {
                string S2 = "";
                char value = S[0];
                count = 0;
                for (int j = 0; j < S.Length; j++)
                {
                    if (S[j] == value)
                    {
                        count++;
                    }
                    else
                    {
                        S2 += count.ToString() + "" + value;
                        value = S[j];
                        count = 1;
                    }
                    if (j == S.Length - 1)
                    {
                        S2 += count.ToString() + "" + value;
                        value = S[j];
                        count = 1;
                        break;
                    }
                }
                S = S2;
            }
            return S;
        }
    }
}

