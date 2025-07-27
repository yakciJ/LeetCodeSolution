namespace LeetCodeSolution
{
    class Program
    {
        // 26/07/2025 | 2210. Count Hills and Valleys in an Array
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution([2, 4, 1, 1, 6, 5])); // Example input  
            Console.WriteLine(Solution([6, 6, 5, 5, 4, 1])); // Example input  
        }

        public static int Solution(int[] nums)
        {
            int i = 0;
            int j = 1;
            string present = "";
            int count = 0;
            while (j < nums.Length && nums[i] == nums[j])
            {
                j++;
            }
            if (j == nums.Length) return 0;
            if (nums[i] < nums[j])
            {
                present = "hill";
            }
            else present = "valley";
            i = j;
            j++;
            while (j < nums.Length)
            {
                if (nums[i] != nums[j])
                {
                    if (nums[i] < nums[j] && present == "valley")
                    {
                        present = "hill";
                        count++;
                    }
                    else if (nums[i] > nums[j] && present == "hill")
                    {
                        present = "valley";
                        count++;
                    }
                    i = j;
                }
                j++;
            }
            return count;
        }
    }
}



