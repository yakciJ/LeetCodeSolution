namespace LeetCodeSolution
{
    class Program
    {
        // 06/07/2025 | 1865. Finding Pairs With a Certain Sum

        public static void Main()
        {
            Console.WriteLine(Solution([2, 2, 3, 4]));
        }
        // 
        public static int Solution(int[] arr)
        {
            
        }
        public class FindSumPairs
        {
            private int[] nums1;
            private int[] nums2;
            private Dictionary<int, int> freq;
            public FindSumPairs(int[] nums1, int[] nums2)
            {
                this.nums1 = nums1;
                this.nums2 = nums2;
                this.freq = new Dictionary<int, int>();
                foreach(int i in nums1)
                {
                    if (freq.ContainsKey(i))
                    {
                        freq[i]++;
                    }
                    else freq[i] = 1;
                }
            }

            public void Add(int index, int val)
            {
                nums2[index] += val;
            }

            public int Count(int tot)
            {
                int count = 0;
                for(int i = 0; i < nums2.Length; i++)
                {
                    if (freq.ContainsKey(tot - nums2[i]))
                    {
                        count += freq[tot - nums2[i]];
                    }
                }
                return count;
            }
        }

        /**
         * Your FindSumPairs object will be instantiated and called as such:
         * FindSumPairs obj = new FindSumPairs(nums1, nums2);
         * obj.Add(index,val);
         * int param_2 = obj.Count(tot);
         */
    }
}