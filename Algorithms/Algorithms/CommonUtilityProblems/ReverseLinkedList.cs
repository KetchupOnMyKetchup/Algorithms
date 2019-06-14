using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.LinkedList;

namespace Algorithms.Algorithms
{
    public class ReverseLinkedList
    {
        // 1 2 3 4 5 
        private Node Reverse(Node head)
        {
            Node following = head; // following = forward
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                // following, current.next, previous, current
                following = following.next;
                current.next = previous;
                previous = current;

                head = current;

                current = following;
            }

            return head;
        }

        public void Run(Node head)
        {
            head = Reverse(head);

            Console.WriteLine(head.data + "-->");

            var current = head;

            while (current != null)
            {
                Console.WriteLine(current.next + "-->");
                current = current.next;
            }

            Console.ReadLine();

        }
    }
}
