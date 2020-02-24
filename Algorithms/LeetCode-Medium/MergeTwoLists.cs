using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode_Medium
{
    class MergeTwoLists1
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode dummy = new ListNode(0);
            ListNode prev = dummy;
            dummy.next = l1.val <= l2.val ? l1 : l2;

            ListNode main = dummy.next;
            ListNode other = l1.val <= l2.val ? l2 : l1;

            while (main != null && other != null) // what if different length LL
            {
                if (main.val > other.val) // put other behind main
                {
                    ListNode temp = main;
                    prev.next = new ListNode(other.val);
                    prev.next.next = temp;

                    main = main.next;

                }
                else
                {
                    ListNode temp = main.next;
                    main.next = new ListNode(other.val);
                    main.next.next = temp;

                    main = main.next.next;
                }

                prev = prev.next;
                other = other.next;
            }

            if (main == null && other != null)
            {
                main.next = other;
            }

            return dummy.next;
        }
    }
}
