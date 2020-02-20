using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _092ReverseLLII
    {

        public class ListNode
        {
            public ListNode(int x)
            {
                val = x;
            }
            public ListNode next;
            public int val;
        }

        //static void Main()
        //{
        //    ListNode node = new ListNode(1);
        //    node.next = new ListNode(2);
        //    node.next.next = new ListNode(3);
        //    node.next.next.next = new ListNode(4);
        //    node.next.next.next.next = new ListNode(5);
        //    node.next.next.next.next.next = new ListNode(6);

        //    var result = ReverseBetween(node, 2, 5);
        //    Console.WriteLine(result);
        //}

        // https://leetcode.com/problems/reverse-linked-list-ii/discuss/30709/Talk-is-cheap-show-me-the-code-(and-DRAWING)
        // ^ see drawing here!!!
        public static ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null || m == n) return head;
            
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            dummy.next = head;


            for (int i = 0; i < m - 1; i++)
            {
                curr = curr.next;
            }

            // tail should be 1 after curr
            ListNode tail = curr.next;

            for (int i = 0; i < n - m; i++)
            {
                // curr = node before section of LL that will be reversed

                // a - setup temp for first node in LL reversal section
                ListNode tmp = curr.next;

                // b - set curr to point 2 ahead (point to end of reversal)
                curr.next = tail.next;

                // c - set tail to 2 ahead (point to other side after LL reversal section)
                tail.next = tail.next.next;

                // d - connect 2 halves of LL
                curr.next.next = tmp;
            }

            return dummy.next;
        }
    }
}
