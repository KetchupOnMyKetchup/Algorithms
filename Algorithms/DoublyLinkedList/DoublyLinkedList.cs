using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DoublyLinkedList
{
    public class DoublyLinkedList
    {
        private DoublyLinkedListNode _head;
        public DoublyLinkedList(DoublyLinkedListNode head)
        {
            _head = head;
        }

        public DoublyLinkedListNode AddFirst(Object data)
        {
            DoublyLinkedListNode newNode = new DoublyLinkedListNode();
            newNode.data = data;

            if (_head != null)
            {
                _head.prev = newNode;
                newNode.next = _head;

            }

            _head = newNode;

            return _head;
        }

        public DoublyLinkedListNode AddLast(Object data)
        {
            DoublyLinkedListNode newNode = new DoublyLinkedListNode();
            newNode.data = data;

            DoublyLinkedListNode current = _head;

            if (current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
            newNode.prev = current.next;

            _head = current;

            return _head;
        }

        public DoublyLinkedListNode Reverse()
        {
            DoublyLinkedListNode current = _head;

            do
            {
                DoublyLinkedListNode old = current.prev;

                current.prev = current.next;
                current.next = old;

                if (current.prev != null)
                {
                    current = current.prev;
                }

            }

            while (current.prev != null);

            _head = current;

            return _head;
        }
    }
}
