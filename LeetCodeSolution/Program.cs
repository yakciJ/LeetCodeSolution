namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 01/05/2025 | 2071. Maximum Number of Tasks You Can Assign
        public static void Main()
        {
            Console.WriteLine(Solution(new int[] { 5, 9, 8, 5, 9 }, new int[] { 1, 6, 4, 2, 6 }, 1, 5));
        }
        public static int Solution(int[] tasks, int[] workers, int pills, int strength)
        {
            // sort 2 mang, chay 1 vong for, neu worker < task thi thu + pill, neu van k thoa man thi tang worker len cho den khi thoa man, sau do tang ca 2.
            //int count = 0;
            //Array.Sort(tasks);
            //Array.Sort(workers);
            //Array.Reverse(workers);
            //Array.Reverse(tasks);
            //int task = 0;
            //int worker = 0;
            //int weakestWorker = workers.Length - 1;
            //Console.WriteLine(string.Join(", ", tasks));
            //Console.WriteLine(string.Join(", ", workers));
            //while (task < tasks.Length && worker <= weakestWorker)
            //{
            //    if (tasks[task] <= workers[worker])
            //    {
            //        Console.WriteLine(workers[worker] + " " + tasks[task]);
            //        count++;
            //        task++;
            //        worker++;
            //    }
            //    else if (tasks[task] <= workers[weakestWorker] + strength && pills > 0)
            //    {
            //        Console.WriteLine("Pill: " + workers[weakestWorker] + " " + tasks[task]);
            //        count++;
            //        weakestWorker--;
            //        task++;
            //        pills--;
            //    }
            //    else
            //    {
            //        task++;
            //    }
            //}
            //return count;
            Array.Sort(tasks);
            Array.Sort(workers);

            int left = 0, right = Math.Min(tasks.Length, workers.Length);

            while (left < right)
            {
                int mid = (left + right + 1) / 2;
                if (CanAssign(tasks, workers, pills, strength, mid))
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }

        private static bool CanAssign(int[] tasks, int[] workers, int pills, int strength, int count)
        {
            LinkedList<int> availableWorkers = new LinkedList<int>(workers.TakeLast(count));
            int remainingPills = pills;

            for (int i = count - 1; i >= 0; i--)
            {
                int task = tasks[i];
                if (availableWorkers.Last.Value >= task)
                {
                    availableWorkers.RemoveLast();
                }
                else if (remainingPills > 0 && availableWorkers.First.Value + strength >= task)
                {
                    availableWorkers.RemoveFirst();
                    remainingPills--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}

