using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Queue
{
    // Linear Queue Array
    // https://www.includehelp.com/dot-net/implement-linear-queue-using-array-using-c-sharp-program.aspx
    //
    public class LinearQueueArray
    {
        private int[] array;
        private int front;
        private int rear;
        private int max;

        public LinearQueueArray(int size)
        {
            array = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                array[++rear] = item;
            }
        }

        public int Dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("deleted element is: " + array[front]);
                return array[front++];
            }
        }

        public void PrintQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + array[i]);
                }
            }
        }
    }
}
