namespace LeetCodeSolution
{
    class Program
    {
        // 07/07/2025 | 1353. Maximum Number of Events That Can Be Attended

        public static void Main()
        {
            Console.WriteLine(Solution([[1, 2], [2, 3], [3, 4]]));
        }
        // min-heap + greedy
        public static int Solution(int[][] events)
        {
            Array.Sort(events, (a, b) => a[0] - b[0]);
            int day = events[0][0];
            int maxDay = 0;
            for (var j = 0; j < events.Length; j++)
            {
                maxDay = Math.Max(maxDay, events[j][1]);
            }
            var lastDay = new PriorityQueue<int, int>();
            int i = 0;
            int max = 0;
            while (day <= maxDay)
            {
                while (i < events.Length && events[i][0] == day)
                {
                    lastDay.Enqueue(events[i][1], events[i][1]);
                    i++;
                }
                while (lastDay.Count > 0 && lastDay.Peek() < day)
                {
                    lastDay.Dequeue();
                }
                if (lastDay.Count > 0)
                {
                    lastDay.Dequeue();
                    max++;
                }
                day++;
            }
            return max;
        }
    }
}