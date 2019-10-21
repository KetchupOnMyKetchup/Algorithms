using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _160IntersectingLL
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        //private static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        //{
        //    Dictionary<int, int> dict = new Dictionary<int, int>();
        //    int count = 0;

        //    while (headA != null)
        //    {
        //        dict.Add(count, headA.val);

        //        count++;
        //        headA = headA.next;
        //    }

        //    bool found = false;
        //    ListNode hold = null;


        //    while (headB != null)
        //    {
        //        if (dict.ContainsValue(headB.val))
        //        {
        //            if (!found && hold == null) hold = headB;
                    
        //            found = true;

        //            if (found && headB.next == null) return hold;
        //        }
        //        else
        //        {
        //            found = false;
        //        }
                
        //        count++;
        //        headB = headB.next;
        //    }

        //    return null;
        //}


        //public static void Main()
        //{
        //    var head = new ListNode(1);
        //    head.next = new ListNode(2);
        //    head.next.next = new ListNode(3);
        //    head.next.next.next = new ListNode(4);

        //    var head2 = new ListNode(0);
        //    head2.next.next = new ListNode(3);
        //    head2.next.next = new ListNode(4);

        //    GetIntersectionNode(head, head2);
        //    Console.ReadLine();
        //}
    }
}
