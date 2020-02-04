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

        static void Main()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(2);
            //head.next.next.next = new ListNode(3);
            //head.next.next.next.next = new ListNode(4);
            //head.next.next.next.next.next = new ListNode(4);
            //head.next.next.next.next.next.next = new ListNode(5);
            var result = DeleteDuplicates(head);

            while (result.next != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
           
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {
            int[] remove = new int[100];
            ListNode curr = head;

            // 2 pass
            // 1st: remove dupes, add to list
            while (curr != null) // 1 further?
            {
                remove[curr.val]++;
                curr = curr.next;
            }

            ListNode dummyHead = new ListNode(0);
            ListNode prev = dummyHead;

            curr = head;

            //2nd: remove dupes from list
            while (curr != null)
            {
                if (remove[curr.val] >= 2)
                {
                    curr = curr.next;
                    continue;
                }

                prev.next = new ListNode(curr.val);

                curr = curr.next;
                prev = prev.next;
            }

            return dummyHead.next;
        }
    }
}
