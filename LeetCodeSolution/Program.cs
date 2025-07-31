
namespace LeetCodeSolution
{
    class Program
    {
        // 31/07/2025 | 898. Bitwise ORs of Subarrays
        // med
        public static void Main()
        {
            Console.WriteLine(Solution([1, 1, 2])); // Example input  
            Console.WriteLine(Solution([1, 2, 4])); // Example input  
        }

        public static int Solution(int[] arr)
        {
            HashSet<int> uniqueOrs = new HashSet<int>();
            HashSet<int> prev = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                HashSet<int> curr = new HashSet<int>();
                foreach (var x in prev)
                {
                    curr.Add(x | arr[i]);
                    uniqueOrs.Add(x | arr[i]);
                }
                curr.Add(arr[i]);
                uniqueOrs.Add(arr[i]);
                prev = curr;
            }
            return uniqueOrs.Count;
        }
    }
}



