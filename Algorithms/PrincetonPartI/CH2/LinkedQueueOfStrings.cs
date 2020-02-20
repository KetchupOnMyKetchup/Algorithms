using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH2
{
    public class LinkedQueueOfStrings
    {
        private Node first, last;

        private class Node // 8 bytes inner class overhead
        {
            public string item; // 8 bytes reference to string
            public Node next; // 8 bytes reference to Node
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void Enqueue(string item)
        {
            Node oldlast = last;
            last = new Node
            {
                item = item,
                next = null
            };

            if (IsEmpty()) first = last; // special cases for empty queue
            else oldlast.next = last;
        }

        public string Dequeue()
        {
            string item = first.item;
            first = first.next;
            if (IsEmpty()) last = null; // special cases for empty queue
            return item;
        }
    }
}
