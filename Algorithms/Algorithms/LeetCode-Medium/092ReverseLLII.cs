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

        static void Main()
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);

            var result = ReverseBetween(node, 2, 4);
            Console.WriteLine(result);
        }

        // https://leetcode.com/problems/reverse-linked-list-ii/discuss/30709/Talk-is-cheap-show-me-the-code-(and-DRAWING)
        public static ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null || m == n) return head;
            
            ListNode dummy = new ListNode(0);
            ListNode p = dummy;
            dummy.next = head;


            for (int i = 0; i < m - 1; i++)
            {
                p = p.next;
            }

            ListNode tail = p.next;

            for (int i = 0; i < n - m; i++)
            {
                // a
                ListNode tmp = p.next;

                // b
                p.next = tail.next;

                // c
                tail.next = tail.next.next;

                // d
                p.next.next = tmp;
            }

            return dummy.next;
        }

    //    ListNode prev = null;
    //    ListNode curr = head;

    //        while (head != null)
    //        {
    //            count++;
    //            if (count<m)
    //            {
    //                prev = curr;
    //                curr = curr.next;
    //                continue;
    //            }

    //            if (count > n) break;

    //            // curr = 2, curr.next = 3

    //            //a
    //            ListNode temp = curr; // 2

    ////b
    //prev.next = curr.next; // 1 --> 3
                
    //            //c
    //            curr.next = curr.next.next; // 2 --> 4

    //            //d


    //            prev = curr;
    //            curr = temp;
    //        }
    }
}
