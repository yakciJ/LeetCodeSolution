namespace LeetCodeSolution
{
    class Program
    {
        // 18/07/2025 | 1233. Remove Sub-Folders from the Filesystem
        // med 

        public static void Main()
        {
            Console.WriteLine(Solution(["/a", "/a/b", "/c/d", "/c/d/e", "/c/f"])); // Example input  
        }
        //  
        public static IList<string> Solution(string[] folder)
        {
            Array.Sort(folder);
            var ans = new List<string>();
            var prev = "";
            foreach (var item in folder)
            {
                if (prev == "" || !item.StartsWith(prev + "/"))
                {
                    ans.Add(item);
                    prev = item;
                    Console.WriteLine(prev);
                }
            }
            return ans;
        }
    }
}



