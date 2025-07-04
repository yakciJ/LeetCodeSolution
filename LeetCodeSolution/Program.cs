namespace LeetCodeSolution
{
    class Program
    {
        // 04/07/2025 | 3307. Find the K-th Character in String Game II

        public static void Main()
        {
            Console.WriteLine(Solution(3, [1, 0]));
        }
        // Tối ưu bài hôm qua thì được bài hôm nay
        public static char Solution(long k, int[] operations)
        {
            long length = 1;
            long res = 0;
            int a = operations.Length - 1;
            for (int i = 0; i < operations.Length; i++)
            {
                if (length >= k)
                {
                    a = i - 1;
                    break;
                }
                length *= 2;
            }
            while (length > 1)
            {
                if (k > length / 2)
                {
                    if (operations[a] == 1)
                    {
                        res = (res + 1) % 26;
                    }
                    k -= length / 2;
                }
                length = length / 2;
                a--;
            }
            res %= 26;
            return (char)('a' + res);
        }
    }
}