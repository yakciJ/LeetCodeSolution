namespace LeetCodeSolution
{
    class Program
    {
        // 12/05/2025 | 1128. Number of Equivalent Domino Pairs
        public static void Main()
        {
            int[] digits = { 2, 1, 3, 0 };
            int[] result = Solution(digits);
            Console.WriteLine(string.Join(", ", result));
        }

        public static int[] Solution(int[] digits)
        {
            List<int> arr = new List<int>();
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < digits.Length; i++)
            {
                if (numbers.ContainsKey(digits[i]))
                {
                    numbers[digits[i]]++;
                }
                else numbers[digits[i]] = 1;
            }
            foreach (int key in numbers.Keys)
            {
                Dictionary<int, int> units = new Dictionary<int, int>(numbers);
                if (key % 2 != 0) continue;
                units[key]--;
                if (units[key] == 0) units.Remove(key);
                foreach (int hundred in units.Keys)
                {
                    Dictionary<int, int> hundreds = new Dictionary<int, int>(units);
                    if (hundred == 0) continue;
                    hundreds[hundred]--;
                    if (hundreds[hundred] == 0) hundreds.Remove(hundred);
                    foreach (int ten in hundreds.Keys)
                    {
                        int sum = hundred * 100 + ten * 10 + key;
                        arr.Add(sum);
                    }
                }
            }
            arr.Sort();
            return arr.ToArray();
        }
    }
}

