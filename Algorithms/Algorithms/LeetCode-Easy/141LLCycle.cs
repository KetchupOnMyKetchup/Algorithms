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

        static void Main()
        {
            ListNode node = new ListNode(3);

            var result = HasCycle(node);
            Console.WriteLine(result);
        }

        public static bool HasCycle(ListNode head)
        {

            return false;
        }
    }
}
