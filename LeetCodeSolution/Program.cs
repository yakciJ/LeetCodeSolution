namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 30/04/2025 | 1295. Find Numbers with Even Number of Digits
        public static void Main()
        {
            Console.WriteLine(Solution(new int[] { 12, 345, 2, 6, 7896 }));
        }
        public static int Solution(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                int x = 0;
                while (n > 0)
                {
                    n = n / 10;
                    x++;
                }
                if (x % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

