using Algorithms.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Queue
{
    public class QueueLinkedList
    {
        Node front;
        Node rear;

        public QueueLinkedList()
        {
            this.front = this.rear = null;
        }

        public void Enqueue(int item)
        {
            Node newNode = new Node(item);

            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                this.rear.next = newNode;
                this.rear = newNode;
            }

            Console.WriteLine("{0} inserted into Queue", item);
        }

        public void Dequeue()
        {
            // If queue is empty, return NULL.  
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            // Store previous front and move front one node ahead  
            Node temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL, then change rear also as NULL  
            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }
        
    }
}
