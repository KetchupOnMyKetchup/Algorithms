using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    // TODO
    class Merge2SortedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }

        //static void Main(string[] args)
        //{
        //    // SEED LIST 1
        //    ListNode node1 = new ListNode(1);
        //    ListNode node3 = new ListNode(3);
        //    ListNode node5 = new ListNode(5);
        //    node1.next = node3;
        //    node3.next = node5;

        //    // SEED LIST 2
        //    ListNode node2 = new ListNode(2);
        //    ListNode node4 = new ListNode(4);
        //    ListNode node6 = new ListNode(6);
        //    node2.next = node4;
        //    node4.next = node6;

        //    var result = MergeTwoLists(node1, node2);

        //    while (result != null)
        //    {
        //        Console.WriteLine(result.val);
        //        result = result.next;
        //    }

        //    Console.ReadLine();
        //}
    }
}
