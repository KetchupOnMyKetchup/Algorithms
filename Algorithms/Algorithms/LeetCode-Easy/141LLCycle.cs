using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _141LLCycle
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
            }
        }

        //static void Main()
        //{
        //    ListNode node = new ListNode(3);
        //    node.next = new ListNode(2);
        //    node.next.next = new ListNode(0);
        //    node.next.next.next = new ListNode(4);
        //    node.next.next.next.next = node.next;

        //    var result = HasCycle(node);
        //    Console.WriteLine(result);
        //}

        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            ListNode slow = head;
            ListNode fast = head;

            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;

                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
    }
}
