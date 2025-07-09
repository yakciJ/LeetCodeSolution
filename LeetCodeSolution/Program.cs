namespace LeetCodeSolution
{
    class Program
    {
        // 09/07/2025 | 3439. Reschedule Meetings for Maximum Free Time I

        public static void Main()
        {
            Console.WriteLine(Solution(5, 1, [1, 3], [2, 5]));
        }
        // dung sliding window
        public static int Solution(int eventTime, int k, int[] startTime, int[] endTime)
        {
            int sum = 0;
            var start = new List<int>(startTime);
            var end = new List<int>(endTime);
            start.Add(eventTime);
            end.Insert(0, 0);
            List<int> free = new List<int>();
            for (int i = 0; i < end.Count; i++)
            {
                free.Add(start[i] - end[i]);
            }
            for (int i = 0; i < k + 1; i++)
            {
                sum += free[i];
            }
            int max = sum;
            for (int i = k + 1; i < free.Count; i++)
            {
                sum += free[i] - free[i - (k+1)];
                if (sum > max) max = sum;
            }
            return max;
        }
    }
}