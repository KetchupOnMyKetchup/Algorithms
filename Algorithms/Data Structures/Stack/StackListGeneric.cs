using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Data_Structures.Stack
{
    class StackListGeneric<T>
    {
        List<T> stack = new List<T>(); 

        public void Push(T value)
        {
            stack.Add(value);
        }

        public T Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
            }

            var node = Peek();

            stack.RemoveAt(stack.Count - 1);

            return node;
        }

        public T Peek()
        {
            return stack[stack.Count - 1];
        }
    }
}
