using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _234PalindromeLL
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        private static bool IsPalindromeLL(ListNode head)
        {
            ListNode fast = head, slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            if (fast != null) // if odd nodes: let right half be smaller
            { 
                slow = slow.next;
            }

            slow = Reverse(slow); // reverse middle to end
            fast = head; // set fast to first half 

            while (slow != null)
            {
                if (fast.val != slow.val) return false;

                fast = fast.next;
                slow = slow.next;
            }

            return true;
        }

        private static ListNode Reverse(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;

            while (curr != null)
            {
                var temp = curr.next;

                curr.next = prev;
                prev = curr;

                curr = temp;
            }

            return prev;
        }

        //public static void Main()
        //{
        //    var head = new ListNode(1);
        //    head.next = new ListNode(2);
        //    head.next.next = new ListNode(2);
        //    head.next.next.next = new ListNode(1);

        //    IsPalindromeLL(head);
        //    Console.ReadLine();
        //}
    }
}
