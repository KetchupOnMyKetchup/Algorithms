using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class AddTwoNumbersLL
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }

        //static void Main()
        //{
        //    // SEED LIST 1
        //    ListNode node1 = new ListNode(1);
        //    ListNode node3 = new ListNode(2);
        //    ListNode node5 = new ListNode(5);
        //    node1.next = node3;
        //    node3.next = node5;

        //    // SEED LIST 2
        //    ListNode node2 = new ListNode(1);
        //    ListNode node4 = new ListNode(2);
        //    ListNode node6 = new ListNode(1);
        //    node2.next = node4;
        //    node4.next = node6;

        //    AddTwoNumbers(node1, node2);
        //}
    }
}
