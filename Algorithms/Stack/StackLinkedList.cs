using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.LinkedList;

namespace Algorithms.Stack
{
    //https://www.geeksforgeeks.org/implement-a-stack-using-singly-linked-list/
    public class StackLinkedList
    {
        Node top;

        public StackLinkedList()
        {
            this.top = null;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);

            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }

            top = newNode;
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
                return;
            }

            top = top.next;
        }

        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow.");
                return;
            }

            Console.WriteLine("{0} is on the top of Stack", this.top.data);
        }
    }
}
