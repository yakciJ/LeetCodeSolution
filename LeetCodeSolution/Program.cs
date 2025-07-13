namespace LeetCodeSolution
{
    class Program
    {
        // 13/07/2025 | 2410. Maximum Matching of Players With Trainers
        // med

        public static void Main()
        {
            Console.WriteLine(Solution([4, 7, 9], [8, 2, 5, 8]));
        }
        // wtf? tuong bai kho ma the d nao

        public static int Solution(int[] players, int[] trainers)
        {
            int count = 0;
            Array.Sort(players);
            Array.Sort(trainers);
            Array.Reverse(players);
            Array.Reverse(trainers);
            int i = 0, j = 0;
            while (i < players.Length && j < trainers.Length)
            {
                if (players[i] <= trainers[j])
                {
                    count++;
                    j++;
                    i++;
                }
                else i++;
            }
            return count;
        }
    }
}