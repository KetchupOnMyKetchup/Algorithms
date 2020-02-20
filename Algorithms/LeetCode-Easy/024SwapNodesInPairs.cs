using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _024SwapNodesInPairs
    {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        
        //public static void Main()
        //{
        //    var head = new ListNode(1);
        //    head.next = new ListNode(2);
        //    head.next.next = new ListNode(3);
        //    head.next.next.next = new ListNode(4);

        //    ListNode result = SwapPairs(head);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        //1234
        //2134
        //2143
        private static ListNode SwapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode curr = dummy;
            
            while (curr.next != null && curr.next.next != null)
            {
                ListNode first = curr.next;
                ListNode second = curr.next.next;

                first.next = second.next;
                curr.next = second;
                second.next = first;

                curr = curr.next.next;
            }

            return dummy.next;
        }
    }
}
