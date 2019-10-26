using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _206ReverseLL
    {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        private static ListNode ReverseLL(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                var nextTemp = curr.next;

                curr.next = prev;
                prev = curr;

                curr = nextTemp;
            }

            return prev;
        }

        public static ListNode reverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode p = reverseList(head.next); // all this to get p=5 and p.next = null. return to prev callstack

            // prev callstack head = 4
            // head.next = 5
            // need 5 to point at --> 4 (which is me)
            // head.next.NEXT = 4
            head.next.next = head;

            // in case this is the tail, set 4.next to null
            head.next = null;
            return p;
        }

        //public static void Main()
        //{
        //    var head = new ListNode(1);
        //    head.next = new ListNode(2);
        //    head.next.next = new ListNode(3);
        //    head.next.next.next = new ListNode(4);
        //    head.next.next.next.next = new ListNode(5);

        //    //ReverseLL(head);
        //    reverseList(head);
        //    Console.ReadLine();
        //}
    }
}
