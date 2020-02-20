using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _002AddTwoNums
    {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        
        //public static void Main()
        //{
        //    ListNode l1 = new ListNode(1);
        //    l1.next = new ListNode(8);
        //    //l1.next.next = new ListNode(3);

        //    ListNode l2 = new ListNode(0);
        //    //l2.next = new ListNode(6);
        //    //l2.next.next = new ListNode(4);

        //    var result = AddTwoNumbers(l1, l2);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;

            while (l1 != null || l2 != null)
            {
                if (curr.next == null) curr.next = new ListNode(0);
                curr = curr.next;

                if (l1 != null)
                { 
                    curr.val += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null) 
                {
                    curr.val += l2.val;
                    l2 = l2.next;
                }
                
                if (curr.val >= 10)
                {
                    curr.val -= 10;
                    curr.next = new ListNode(1);
                }
            }

            return dummy.next;
        }
    }
}
