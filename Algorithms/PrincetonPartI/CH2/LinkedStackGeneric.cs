using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH2
{
    /// <summary>
    /// </summary>
    public class LinkedStackGeneric<T>
    {
        private Node first = null;

        private class Node
        {
            public T item;
            public Node next;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void Push(T item)
        {
            Node oldFirst = first;
            first = new Node();
            first.item = item;
            first.next = oldFirst;
        }

        public T Pop()
        {
            T item = first.item;
            first = first.next;
            return item;
        }
    }
}
