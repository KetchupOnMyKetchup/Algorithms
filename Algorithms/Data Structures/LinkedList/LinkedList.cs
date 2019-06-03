using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public class LinkedList2
    {
        private Node _head;
        public LinkedList2(Node head)
        {
            _head = head;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public void PrintAllNodes()
        {
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public List<Node> ReturnAllNodes()
        {
            List<Node> nodes = new List<Node>();

            Node current = _head;
            while (current != null)
            {
                nodes.Add(current);
                current = current.next;
            }

            return nodes;
        }

        public void AddFirst(Object data)
        {
            Node newNode = new Node();

            newNode.data = data;

            if (_head != null)
            {
                newNode.next = _head;
            }

            _head = newNode;
        }

        public void AddLast(Object data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                Node current = _head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
            }
        }
    }
}
