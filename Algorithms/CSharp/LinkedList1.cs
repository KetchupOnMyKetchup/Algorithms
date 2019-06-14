using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CSharp.LL
{
    public class LinkedList1<T>
    {
        private class Node<T>
        {
            public Node(T data)
            {
                Data = data;
            }

            public T Data { get; set; }
            public Node<T> Next { get; set; }
        }

        private Node<T> _head;

        public bool IsEmpty()
        { 
            return _head == null;
        }


        public void AddFirst(T data)
        {
            if (_head != null)
            {
                var oldHead = _head;
                _head = new Node<T>(data);
                _head.Next = oldHead;
            }
            else
            {
                _head = new Node<T>(data);
            }
        }

        public void AddLast(T data)
        {
            if (_head == null)
            {
                _head = new Node<T>(data);
            }
            else
            {
                Node<T> current = _head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new Node<T>(data);
            }
        }

        public void AddAfter(T data)
        {

        }

        public void ListAll()
        {
            Console.WriteLine($"Head is {_head}");

            var current = _head;

            while (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine($"Next node value is {current.Data} and current.Next is {current.Next}");
            }
        }

        public void Remove(T data)
        {

        }

        public void Clear()
        {

        }

        public void Reverse()
        {
            Node<T> current = _head;
            Node<T> previous = null;
            Node<T> next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;

                previous = current;
                current = next;
            }

            _head = previous;
        }

        public void ReverseArray(T[] myArray)
        {
            int length = myArray.Length;
            int index = length - 1;

            for (int i = 0; i < length / 2; i++)
            {
                var temp = myArray[i];
                myArray[i] = myArray[index - i];
                myArray[index - i] = temp;
            }

        }

        //public void Reverse()
        //{
        //    Node<T> prev = null, 
        //            current = _head, // 1
        //            next = null;

        //    while (current != null)
        //    {
        //        next = current.Next; // increment next pointer so we can store in a temp var
        //        current.Next = prev; // make the pointer to the right, now will go pointll to the left (stored in current.Next)
        //        prev = current; // increment prev pointer 
        //        current = next; // increment current pointer
        //    }

        //    _head = prev; // set head to the last value.
        //}
    }
}
