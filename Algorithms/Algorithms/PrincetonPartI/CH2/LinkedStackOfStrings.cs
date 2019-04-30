using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH2
{
    /// <summary>
    /// ~40N bytes
    /// </summary>
    public class LinkedStackOfStrings // 16 bytes ovject overhead
    {
        private Node first = null;

        private class Node // 8 bytes inner class overhead
        {
            public string item; // 8 bytes reference to string
            public Node next; // 8 bytes reference to Node
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void Push(string item)
        {
            Node oldFirst = first;
            first = new Node();
            first.item = item;
            first.next = oldFirst;
        }

        public string Pop()
        {
            string item = first.item;
            first = first.next;
            return item;
        }
    }
}
