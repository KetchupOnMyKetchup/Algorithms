//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Algorithms.Algorithms.LeetCode_Easy
//{
//    class _155MinStack
//    {
//        public class MinStack
//        {
//            static readonly int maxSize = 1000;
//            int[] stack = new int[maxSize];
//            int top;
//            int min;

//            public MinStack()
//            {

//            }

//            public void Push(int x)
//            {
//                stack[++top] = x;

//                if (x < min)
//                {
//                    min = x;
//                }
//            }

//            public void Pop()
//            {
//                if (top == min)
//                {
//                    // find new min
//                }

//                top--;
//            }

//            public int Top()
//            {
//                return top;
//            }

//            public int GetMin()
//            {
//                return min;
//            }
//        }

//        public static void Main()
//        {
//            MinStack obj = new MinStack();
//            obj.Push(3);
//            obj.Pop();
//            int num1 = obj.Top();
//            int num2 = obj.GetMin();
//            Console.ReadLine();
//        }
//    }
//}
