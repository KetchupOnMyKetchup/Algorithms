using Algorithms.Stack;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Algorithms
{
    class Stack1
    {

        int top;
        List<int> stack = new List<int>();

        public Stack1()
        {
            top = -1;
        }

        public bool Push(int data)
        {
            top++;

            if (top == stack.Count)
            {
                stack.Add(data);
            }
            else
            {
                stack[top] = data;
            }
            return true;
        }

        public void Pop()
        {
            int value = stack[top--];
        }

        public void Peek()
        {
            Console.WriteLine(stack.Take(top + 1).Max());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack1 stack = new Stack1();

            int count;
                
            int.TryParse(Console.ReadLine(), out count);

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();

                string[] inputWords = input.Split(' ');
                int[] inputNumbers = Array.ConvertAll(inputWords, s => int.Parse(s));


                if (inputNumbers[0] == 1)
                {
                    stack.Push(inputNumbers[1]);
                }
                else if (inputNumbers[0] == 2)
                {
                    stack.Pop();
                }
                else if (inputNumbers[0] == 3)
                {
                    stack.Peek();
                }
            }
        }
    }
}
