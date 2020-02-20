using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _019RemoveNthNodeLL
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }


        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0); // See * below
            dummy.next = head;

            ListNode first = dummy;
            ListNode second = dummy;

            for (int i = 1; i <= n + 1; i++)
            {
                first = first.next;
            }

            while(first != null)
            {
                first = first.next;
                second = second.next;
            }

            second.next = second.next.next; // *dummy ensures these won't be null, or if .next.next is null then there was only 1 value
            
            return dummy.next;
        }

        //public static void Main()
        //{
        //    var head = new ListNode(1);
        //    //head.next = new ListNode(2);
        //    //head.next.next = new ListNode(3);
        //    //head.next.next.next = new ListNode(4);
        //    //head.next.next.next.next = new ListNode(5);

        //    RemoveNthFromEnd(head, 1);
        //    Console.ReadLine();
        //}
    }
}
