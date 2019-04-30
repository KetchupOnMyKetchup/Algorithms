using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH2
{
    /// <summary>
    /// Slide 13, 14:33
    /// </summary>
    public class FixedCapacityStackOfStrings
    {
        private string[] s;
        private int N = 0;

        public FixedCapacityStackOfStrings(int capacity)
        {
            s = new string[capacity];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public void Push(string item)
        {
            s[N++] = item;
        }

        public string Pop()
        {
            // avoid "loitering" so GC can reclaim memory if no outstanding references
            string item = s[--N];
            s[N] = null;
            return item;
        }
    }
}
