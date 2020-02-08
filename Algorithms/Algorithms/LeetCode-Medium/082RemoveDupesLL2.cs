using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _082RemoveDupesLL2
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        //static void Main()
        //{
        //    ListNode head = new ListNode(1);
        //    head.next = new ListNode(2);
        //    head.next.next = new ListNode(2);
        //    //head.next.next.next = new ListNode(3);
        //    //head.next.next.next.next = new ListNode(4);
        //    //head.next.next.next.next.next = new ListNode(4);
        //    //head.next.next.next.next.next.next = new ListNode(5);
        //    var result = DeleteDuplicates(head);

        //    while (result.next != null)
        //    {
        //        Console.WriteLine(result.val);
        //        result = result.next;
        //    }
           
        //}

        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            
            ListNode dummyHead = new ListNode(0);
            dummyHead.next = head;

            ListNode prev = dummyHead;
            ListNode curr = head;

            while (curr != null)
            {
                while (curr.next != null && curr.val == curr.next.val) curr = curr.next;
                
                // reference, its equal if its pointing to the NEXT object in line.. regardless of values being the same or not
                // if prev.next points to same place in computer as curr does
                if (prev.next == curr) prev = prev.next;
                else prev.next = curr.next;

                curr = curr.next;
            }

            return dummyHead.next;
        }
    }
}
