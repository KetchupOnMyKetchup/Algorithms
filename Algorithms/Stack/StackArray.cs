using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stack
{
    //https://www.geeksforgeeks.org/implementing-stack-c-sharp/
    class StackArray
    {
        static readonly int max = 1000;
        int top;
        int[] stack = new int[max];

        public StackArray()
        {
            top = -1;
        }

        bool IsEmpty()
        {
            return (top < 0);
        }

        public bool Push(int data)
        {
            if (top >= max)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                Console.WriteLine("The topmost element of Stack is: {0}", stack[top]);
            }
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");

                for (int i = top; i >= 0; i++)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
