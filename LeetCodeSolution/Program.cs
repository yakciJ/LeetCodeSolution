namespace LeetCodeSolution
{
    class Program
    {
        // 11/08/2025 | 1913. Maximum Product Difference Between Two Pairs
        // ez
        // 
        public static void Main()
        {
            Console.WriteLine(Solution([5, 6, 2, 7, 4]));
            Console.WriteLine(Solution([4, 2, 5, 9, 7, 4, 8]));
            //Console.WriteLine(Solution(["po", "zsz"]));
        }

        public static int Solution(int[] nums)
        {
            int num1 = int.MaxValue;
            int num2 = int.MaxValue;
            int num3 = int.MinValue;
            int num4 = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > num4)
                {
                    num3 = num4;
                    num4 = nums[i];
                }
                else if (nums[i] > num3)
                {
                    num3 = nums[i];
                }
                if (nums[i] < num2)
                {
                    num1 = num2;
                    num2 = nums[i];
                }
                else if (nums[i] < num1)
                {
                    num1 = nums[i];
                }
            }
            return (num3 * +num4) - (num1 * num2);
        }
    }
}



