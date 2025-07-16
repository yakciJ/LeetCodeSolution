namespace LeetCodeSolution
{
    class Program
    {
        // 16/07/2025 | 3201. Find the Maximum Length of Valid Subsequence I      
        // med 

        public static void Main()
        {
            Console.WriteLine(Solution([1, 2, 4, 7, 5, 8, 6, 3, 9, 10])); // Example input  
        }
        //   
        public static int Solution(int[] nums)
        {
            int countOdd = 0;
            int countEven = 0;
            int present = nums[0];
            int count = 1;
            if (nums[0] % 2 == 0)
            {
                countEven++;
            }
            else countOdd++;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    countEven++;
                }
                else countOdd++;
                if ((nums[i] + present) % 2 != 0)
                {
                    count++;
                    present = nums[i];
                }
            }
            int res = countEven > countOdd ? countEven : countOdd;
            res = res > count ? res : count;
            return res;
        }
    }
}
