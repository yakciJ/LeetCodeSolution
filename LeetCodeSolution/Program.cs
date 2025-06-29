namespace LeetCodeSolution
{
    class Program
    {
        // 29/6/2025 | 1498. Number of Subsequences That Satisfy the Given Sum Condition

        public static void Main()
        {
            Console.WriteLine(Solution([3, 4, 3, 3], 2));
        }
        // Số lớn hơn target = vứt, tìm 2 số đầu số cuối, là min và max thỏa mãn tổng < target, min thì auto lấy còn max thì so với min, nếu tổng < target thì lấy, k thì vứt, số mà to hơn target cũng vứt luôn, sau đó tìm toàn bộ các số nằm giữa nó, tính tổng các dãy con vẫn phải chứa min và max, sau đó giảm max xuống 1 số, rồi lại tính tiếp.
        public static int Solution(int[] nums, int target)
        {
            long count = 0;
            Array.Sort(nums);
            int left = 0;
            int right = nums.Length-1;
            const long MOD = 1_000_000_007;

            while (left <= right && right < nums.Length)
            {
                if (nums[left] + nums[right] <= target)
                {
                    count = (count + PowerMod(2, right - left, MOD)) % MOD;
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return (int)count;
        }
        public static long PowerMod(long baseVal, long exp, long mod)
        {
            long result = 1;
            baseVal %= mod;

            while (exp > 0)
            {
                if ((exp & 1) == 1)  // nếu exp là số lẻ
                    result = (result * baseVal) % mod;

                baseVal = (baseVal * baseVal) % mod;
                exp >>= 1; // chia exp cho 2
            }

            return result;
        }
    }
}