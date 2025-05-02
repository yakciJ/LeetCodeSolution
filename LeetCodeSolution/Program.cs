namespace LeetCodeSolution
{
    using System;

    class Program
    {
        // 02/05/2025 | 838. Push Dominoes  
        public static void Main()
        {
            //string dominoes = "..R...L..";
            //char[] dominoArray = dominoes.ToCharArray();
            //Console.WriteLine(Fall(dominoArray, 2, 6, 'B'));
            Console.WriteLine(Solution(".L.R...LR..L.."));
        }

        public static string Solution(string dominoes)
        {
            int dot = 0;
            int pos = 0;
            char[] dominoArray = dominoes.ToCharArray();
            char now = dominoArray[0];

            for (int i = 1; i < dominoArray.Length; i++)
            {
                if (dominoArray[i] == '.')
                {
                    dot++;
                    continue;
                }
                if (dominoArray[i] == 'L' && now == '.')
                {
                    dominoArray = Fall(dominoArray, -1, i, 'L');
                    now = dominoArray[i];
                    pos = i;
                    dot = 0;
                    continue;
                }
                if (dominoArray[i] == now && dot > 0)
                {
                    dominoArray = Fall(dominoArray, pos, i, dominoArray[i]);
                    pos = i;
                    dot = 0;
                    now = dominoArray[i];
                }
                else if (dominoArray[i] == 'L' && now == 'R' && dot > 1)
                {
                    dominoArray = Fall(dominoArray, pos, i, 'B');
                    pos = i;
                    dot = 0;
                    now = dominoArray[i];
                }
                else
                {
                    now = dominoArray[i];
                    dot = 0;
                    pos = i;
                }
            }
            if (now == 'R')
            {
                dominoArray = Fall(dominoArray, pos, dominoArray.Length, now);
            }
            return new string(dominoArray);
        }

        public static char[] Fall(char[] dominoArray, int first, int last, char direction)
        {
            if (direction == 'L' || direction == 'R')
            {
                for (int i = first + 1; i < last; i++)
                {
                    dominoArray[i] = direction;
                }
            }
            else
            {
                if ((last - first - 1) % 2 == 0)
                {
                    int mid = first + (last - first) / 2;
                    for (int i = first + 1; i < last; i++)
                    {
                        if (i <= mid)
                        {
                            dominoArray[i] = 'R';
                        }
                        else dominoArray[i] = 'L';
                    }
                }
                else
                {
                    int mid = first + (last - first) / 2;
                    for (int i = first + 1; i < last; i++)
                    {
                        if (i == mid) continue;
                        if (i < mid)
                        {
                            dominoArray[i] = 'R';
                        }
                        else dominoArray[i] = 'L';
                    }
                }
            }
            return dominoArray;
        }
    }
}

