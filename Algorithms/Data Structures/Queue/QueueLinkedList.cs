using Algorithms.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Queue
{
    /// <summary>
    /// LL with a queue
    /// </summary>
    public class QueueLinkedList
    {
        Node head;
        Node tail;

        public QueueLinkedList()
        {
            this.head = this.tail = null;
        }

        public void Enqueue(int item)
        {
            Node newNode = new Node(item);

            if (this.tail == null)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                this.tail.next = newNode;
                this.tail = newNode;
            }

            Console.WriteLine("{0} inserted into Queue", item);
        }

        public void Dequeue()
        {
            // If queue is empty, return NULL.  
            if (this.head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            // Store previous front and move front one node ahead  
            Node temp = this.head;
            this.head = this.head.next;

            // If front becomes NULL, then change rear also as NULL  
            if (this.head == null)
            {
                this.tail = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }
        
    }
}
