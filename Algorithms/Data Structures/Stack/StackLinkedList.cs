using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.LinkedList;

namespace Algorithms.Stack
{
    //https://www.geeksforgeeks.org/implement-a-stack-using-singly-linked-list/
    // A stack with N items uses ~40N bytes
    public class StackLinkedList // 16 bytes overhead
    {
        Node top; // 8 bytes for Node inner class overhead + 8 bytes to node reference
        // Node.value 8 bytes reference to string
        // Node.next 8 bytes reference to next node

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
