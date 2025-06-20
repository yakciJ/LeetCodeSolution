namespace LeetCodeSolution
{
    class Program
    {
        // 20/6/2025 | 2294. Partition Array Such That Maximum Difference Is K
        public static void Main()
        {
            Console.WriteLine(Solution("NWSE", 1));
        }

        public static int Solution(string s, int k)
        {
            int farthest = 0;
            char[][] arr = new char[4][];
            arr[0] = new char[] { 'N', 'E' };
            arr[1] = new char[] { 'N', 'W' };
            arr[2] = new char[] { 'S', 'E' };
            arr[3] = new char[] { 'S', 'W' };

            for (int i = 0; i < 4; i++)
            {
                int temp = 0;
                int maxTemp = 0;
                int tempK = k;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == arr[i][0] || s[j] == arr[i][1])
                    {
                        temp++;
                    }
                    else
                    {
                        if (tempK > 0)
                        {
                            temp++;
                            tempK--;
                        }
                        else
                        {
                            temp--;
                        }
                    }
                    if (temp > maxTemp) maxTemp = temp;
                }
                if (farthest < maxTemp) farthest = maxTemp;
            }
            return farthest;
        }
    }
}

