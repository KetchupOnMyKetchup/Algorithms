using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _083RemoveDupes
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static void Main()
        {
            var head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(2);

            ListNode result = DeleteDuplicates(head);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return head;
            
            ListNode prev = head; // should have used curr and curr.next instead of a prev pointer
            ListNode curr = head.next;

            while (curr != null)
            {
                if (prev.val == curr.val)
                {
                    prev.next = curr.next;
                    curr = prev.next;
                }
                else
                {
                    prev = curr;
                    curr = curr.next;
                }
            }

            return head;
        }
    }
}
