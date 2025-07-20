namespace LeetCodeSolution
{
    class Program
    {
        // 20/07/2025 | 203. Remove Linked List Elements
        // ez
        public static void Main()
        {
            Console.WriteLine(Solution(["/a", "/a/b", "/c/d", "/c/d/e", "/c/f"])); // Example input  
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        static public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            Recursion(dummy, val);
            return dummy.next;
        }

        static public void Recursion(ListNode head, int val)
        {
            if (head == null || head.next == null) return;
            if (head.next.val == val)
            {
                head.next = head.next.next;
                Recursion(head, val);
            }
            else Recursion(head.next, val);
        }


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



