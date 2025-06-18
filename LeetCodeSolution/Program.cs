namespace LeetCodeSolution
{
    class Program
    {
        // 18/6/2025 | 2966. Divide Array Into Arrays With Max Difference
        public static void Main()
        {
            Console.WriteLine(Solution([1, 3, 4, 8, 7, 9, 3, 5, 1], 2));
        }

        public static int[][] Solution(int[] nums, int k)
        {
            // biet truoc duoc do dai cua mang la nums.Length/3 roi,
            // cho chạy 1 vòng, cho số đầu tiên vào 1 mảng trong danh sách mảng tạm thời temp, đến số tiếp theo thì so với các số trong mảng của mảng tạm thời, nếu thỏa mãn ( khoảng cách <= k) thì cho vào, nếu đủ 3 thì vứt vào res, nếu không thỏa mãn ở mảng này thì so với mảng sau, nếu tất cả mảng trong mảng tạm thời k chứa được thì cho vào mảng tạm thời mới. Nếu chạy xong mà mảng res vẫn k đủ độ dài = nums.Length/3 thì return mảng rỗng khác.
            List<List<int>> res = new List<List<int>>();
            List<List<int>> temp = new List<List<int>>();
            temp.Add(new List<int>());
            Array.Sort(nums);
            temp[0].Add(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                bool isAdd = false;
                for (int j = 0; j < temp.Count; j++)
                {
                    bool isSatisfy = true;
                    for (int x = 0; x < temp[j].Count; x++)
                    {
                        if (Math.Abs(nums[i] - temp[j][x]) > k){
                            isSatisfy = false;
                            break;
                        }
                    }
                    if (isSatisfy)
                    {
                        temp[j].Add(nums[i]);
                        if (temp[j].Count == 3)
                        {
                            res.Add(temp[j]);
                            temp.RemoveAt(j);
                        }
                        isAdd = true;
                        break;
                    }
                }
                if (!isAdd)
                {
                    temp.Add(new List<int> { nums[i] });
                }
            }
            if (res.Count < nums.Length / 3) return new int[0][];
            int[][] result = res.Select(row => row.ToArray()).ToArray();
            return result;
        }
    }
}

