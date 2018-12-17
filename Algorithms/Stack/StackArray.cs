using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Stack
{
    class StackArray
    {
        static readonly int max = 1000;
        int top;
        int[] stack = new int[max];

        bool IsEmpty()
        {
            return (top < 0);
        }

    }
}
