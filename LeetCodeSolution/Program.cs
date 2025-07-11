namespace LeetCodeSolution
{
    class Program
    {
        // 11/07/2025 | 21. Merge Two Sorted Lists

        public static void Main()
        {
            //Console.WriteLine(Solution(10, [0, 3, 7, 9], [1, 4, 8, 10]));
        }
        // hoc LinkedList
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
        public static ListNode Solution(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            while(list1 != null && list2 != null)
            {
                if(list1.val <= list2.val)
                {
                    current.next = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    current.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                current = current.next;
            }
            current.next = list1 ?? list2;
            return dummy.next;
        }
    }
}