namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 03/05/2025 | 1007. Minimum Domino Rotations For Equal Row
        public static void Main()
        {
            Console.WriteLine(Solution(
                new int[] { 2, 1, 2, 4, 2, 2 },
                new int[] { 5, 2, 6, 2, 3, 2 }
            )); // Expected: 2

            //Console.WriteLine(Solution(
            //    new int[] { 3, 5, 1, 2, 3 },
            //    new int[] { 3, 6, 3, 3, 4 }
            //)); // Expected: -1

            //Console.WriteLine(Solution(
            //    new int[] { 1, 1, 1, 1 },
            //    new int[] { 2, 2, 2, 2 }
            //)); // Expected: 0 
        }

        public static int Solution(int[] tops, int[] bottoms)
        {
            int Check(int x)
            {
                int topCount = 0;
                int bottomCount = 0;
                for (int i = 0; i < bottoms.Length; i++)
                {
                    if (tops[i] != x && bottoms[i] != x)
                    {
                        return -1;
                    }
                    else if (tops[i] != x)
                    {
                        topCount++;
                    }
                    else if (bottoms[i] != x)
                    {
                        bottomCount++;
                    }
                }
                return Math.Min(topCount, bottomCount);
            }
            int count = Check(tops[0]);
            if (count > 0) return count;
            return Check(bottoms[0]);
        }
    }
}

