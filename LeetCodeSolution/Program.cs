namespace LeetCodeSolution
{
    class Program
    {
        // 16/07/2025 | 3467. Transform Array by Parity
        // ez 

        public static void Main()
        {
            Console.WriteLine(Solution([4, 3, 2, 1])); // Example input  
        }
        //  hoc ve sort truoc roi moi hoc dc ve binary, vi binary can sort
        public static int[] Solution(int[] nums)
        {
            int count = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    count++;
                }
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if(i < count)
                {
                    nums[i] = 0;
                }
                else nums[i] = 1;
            }
            return nums;
        }
    }
}
