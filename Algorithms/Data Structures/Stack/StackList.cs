using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Data_Structures.Stack
{
    class StackList
    {
        List<int> stack = new List<int>(); 

        public void Push(int value)
        {
            stack.Add(value);
        }

        public int Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
            }

            var node = Peek();

            stack.RemoveAt(stack.Count - 1);

            return node;
        }

        public int Peek()
        {
            return stack[stack.Count - 1];
        }
    }
}
