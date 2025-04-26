namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 25/04/2025
        public static void Main()
        {
            Console.WriteLine(Solution(new List<int> { 3, 1, 9, 6 }, 3, 0));
            //Console.WriteLine(Solution(new List<int> { 3, 2, 4 }, 2, 1));
            //Console.WriteLine(Solution(new List<int> { 3, 1, 9, 6 }, 3, 0));  // Expected: 5
            //Console.WriteLine(Solution(new List<int> { 2, 2, 2 }, 2, 1));     // Expected: 0
            //Console.WriteLine(Solution(new List<int> { 1, 2, 3, 4 }, 2, 1));  // Expected: 4
            //Console.WriteLine(Solution(new List<int> { 1, 3, 5, 7 }, 2, 1));
        }
        public static long Solution(IList<int> nums, int modulo, int k)
        {
            // Lưu tất cả các chỉ mục của các số thỏa mãn vào 1 mảng arr, nếu gặp 1 số thỏa mãn khi tổng số phần từ của mảng đấy % modulo == k thì ta sẽ tính tổng số các mảng con thỏa mãn từ i = left cho đến i = hiện tại -1 = công thức tính tất cả các mảng con và trừ đi mảng con ở 2 đầu và mảng con ở giữa. Sau khi tính xong thì loại bỏ phần tử đầu tiên của arr và thêm phần tử vừa được xét vào và duyệt tiếp mảng.
            int n = nums.Count;
            int i = 0;
            long count = 0;
            List<int> arr = new List<int>();
            foreach (int num in nums)
            {
                if (num % modulo == k)
                {
                    arr.Add(i);
                }
                i++;
            }
            if (k == 0)
            {
                int prev = -1;
                foreach (int idx in arr)
                {
                    int gapLen = idx - prev - 1;
                    count += (long)gapLen * (gapLen + 1) / 2;
                    prev = idx;
                }
                int lastGap = n - 1 - (arr.Count > 0 ? arr[^1] : -1);
                count += (long)lastGap * (lastGap + 1) / 2;
            }
            for (int left = 0; left < arr.Count; left++)
            {
                for (int right = left; right < arr.Count; right++)
                {
                    int len = right - left + 1;
                    if (len % modulo != k)
                        continue;

                    int prevIndex = (left == 0 ? -1 : arr[left - 1]);
                    int nextIndex = (right == arr.Count - 1 ? n : arr[right + 1]);
                    long choicesLeft = arr[left] - prevIndex;
                    long choicesRight = nextIndex - arr[right];
                    count += choicesLeft * choicesRight;
                }
            }
            return count;
        }
    }
}

