namespace LeetCodeSolution
{
    class Program
    {
        // 07/08/2025 | 171. Excel Sheet Column Number
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution([-100, -2, -3, 1]));
            Console.WriteLine(Solution([1, 2, 3, 4]));
            Console.WriteLine(Solution([-1, -2, -3]));
        }

        public static int Solution(int[] nums)
        {
            int[] max = new int[] { int.MinValue, int.MinValue, int.MinValue };
            int[] min = new int[] { int.MaxValue, int.MaxValue };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max[0])
                {
                    max[0] = nums[i];
                    Array.Sort(max);
                }
                if (nums[i] < 0 && nums[i] < min[1])
                {
                    min[1] = nums[i];
                    Array.Sort(min);
                }
            }
            int res = max[0] * max[1] * max[2];
            if (min[0] != int.MaxValue && min[1] != int.MaxValue)
            {
                int max2 = min[0] * min[1] * max[2];
                res = Math.Max(res, max2);
            }
            return res;
        }
    }
}



