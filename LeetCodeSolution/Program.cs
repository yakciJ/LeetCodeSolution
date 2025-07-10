namespace LeetCodeSolution
{
    class Program
    {
        // 10/07/2025 | 3440. Reschedule Meetings for Maximum Free Time II

        public static void Main()
        {
            Console.WriteLine(Solution(10, [0, 3, 7, 9], [1, 4, 8, 10]));
        }
        // dung ...
        public static int Solution(int eventTime, int[] startTime, int[] endTime)
        {
            int max = 0;
            var start = new List<int>(startTime);
            var end = new List<int>(endTime);
            start.Add(eventTime);
            end.Insert(0, 0);
            var free = new List<(int length, int index)>();
            for (int i = 0; i < end.Count; i++)
            {
                free.Add((start[i] - end[i], i));
            }
            if (free.Count >= 2)
            {
                int sum = free[0].length + free[1].length;
                max = sum;

                for (int i = 2; i < free.Count; i++)
                {
                    sum += free[i].length - free[i - 2].length;
                    if (sum > max) max = sum;
                }
            }
            else if (free.Count == 1)
            {
                max = free[0].length;
            }
            else
            {
                max = 0;
            }
            var freeCopy = new List<(int length, int index)>(free);
            free.Sort((a, b) => b.length.CompareTo(a.length));
            for (int i = 0; i < startTime.Length; i++)
            {
                int meeting = endTime[i] - startTime[i];
                for (int j = 0; j < free.Count; j++)
                {
                    if (free[j].length >= meeting && free[j].index != i && free[j].index != i + 1)
                    {
                        max = Math.Max(freeCopy[i].length + freeCopy[i + 1].length + meeting, max);
                        break;
                    }
                    else if(free[j].length < meeting) break;
                }
            }
            return max;
        }
    }
}