namespace LeetCodeSolution
{
    class Program
    {
        // 14/07/2025 | 1290. Convert Binary Number in a Linked List to Integer
        // ez

        public static void Main()
        {
            //Console.WriteLine(Solution([1, 0, 1]);
        }
        // hoc ve shift left operation, hoc ve toan tu lq den bit
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
        public static int Solution(ListNode head)
        {
            int res = 0;
            while (head != null)
            {
                res = (res << 1) | head.val;
                head = head.next;
            }
            return res;
        }
    }
}