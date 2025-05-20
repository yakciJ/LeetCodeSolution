namespace LeetCodeSolution
{
    class Program
    {
        // 20/05/2025 | 3355. Zero Array Transformation I
        public static void Main()
        {
            Console.WriteLine(Solution([4, 3, 2, 1], [[1, 3], [0, 2]]));
        }

        public static bool Solution(int[] nums, int[][] queries)
        {
            // Cach moi, tao mang moi, den doan trong mang thi -1, ra khoi mang thi +1, sau do dung prefix sum de tinh so lan +- gi do de + vao nums.
            int[] diffs = new int[nums.Length + 1];
            int diff = 0;
            for (int i = 0; i < queries.Length; i++)
            {
                diffs[queries[i][0]]--;
                diffs[queries[i][1] + 1]++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                diff += diffs[i];
                nums[i] += diff;
                if (nums[i] > 0) return false;
            }
            return true;
            //Cach cu, TLE.
            //for (int i = 0; i < queries.Length; i++)
            //{
            //    for (int j = queries[i][0]; j <= queries[i][1]; j++)
            //    {
            //        if (nums[j] > 0) nums[j]--;
            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] != 0) return false;
            //}
            //return true;
        }
    }
}

