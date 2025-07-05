namespace LeetCodeSolution
{
    class Program
    {
        // 05/07/2025 | 1394. Find Lucky Integer in an Array

        public static void Main()
        {
            Console.WriteLine(Solution([2, 2, 3, 4]));
        }
        // 
        public static int Solution(int[] arr)
        {
            int lucky = -1;
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (freq.ContainsKey(i))
                {
                    freq[i]++;
                }
                else freq[i] = 1;
            }
            foreach (var temp in freq)
            {
                if (temp.Value == temp.Key)
                {
                    if (temp.Key > lucky)
                    {
                        lucky = temp.Key;
                    }
                }
            }
            return lucky;
        }
    }
}