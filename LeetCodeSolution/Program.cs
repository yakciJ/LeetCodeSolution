namespace LeetCodeSolution
{
    class Program
    {
        // 04/08/2025 | 904. Fruit Into Baskets
        // med
        public static void Main()
        {
            Console.WriteLine(Solution([3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4]

));
            //Console.WriteLine(Solution([0, 1, 2, 2]));
            //Console.WriteLine(Solution([1, 2, 3, 2, 2]));
        }

        public static int Solution(int[] fruits)
        {
            int max = 0;
            int count = 0;
            int present = 0;
            int last = 0;
            int fruit1 = -1;
            int fruit2 = -1;
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(count);
                Console.WriteLine("fruit 1: " + fruit1);
                Console.WriteLine("fruit 2: " + fruit2);
                Console.WriteLine("present: " + present);
                Console.WriteLine("last: " + last);
                if (fruit1 == -1)
                {
                    fruit1 = fruits[i];
                    present = fruits[i];
                }
                else if (fruit2 == -1)
                {
                    fruit2 = fruits[i];
                }
                if (fruits[i] == fruit1 || fruits[i] == fruit2)
                {
                    count++;
                }
                else
                {
                    if (count > max) max = count;
                    count = last + 1;
                    fruit1 = fruits[i - 1];
                    fruit2 = fruits[i];
                }
                if (fruits[i] != present)
                {
                    present = fruits[i];
                    last = 1;
                }
                else
                {
                    last++;
                }
            }
            if (count > max) max = count;
            return max;
        }
    }
}



