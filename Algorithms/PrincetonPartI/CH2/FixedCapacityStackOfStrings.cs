using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH2
{
    /// <summary>
    /// Slide 13, 14:33
    /// Uses between ~8N (when full) and ~32N (when 1/4 full) bytes to represent a stack of N items
    /// ^ for stack itself not the string, the client owns the strings. 
    /// **Total amount of time is faster and less wasted space than a linked list version. Individual operation might be slower than linked list version.
    /// </summary>
    public class FixedCapacityStackOfStrings
    {
        private string[] s; // 8 bytes reference to array + 24 bytes array overhead + 8 bytes x array size
        private int N = 0; // 4 bytes for int
        // 4 bytes padding
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
            // if array is full, create a new array of twice the size "repeated doubling" and copy items
            if (N == s.Length) Resize(2 * s.Length);

            s[N++] = item;
        }

        // Array is usually between 25% - 100% full, except when first being utilized
        private void Resize(int capacity)
        {
            string[] copy = new string[capacity];

            for (int i = 0; i < N; i++)
            {
                copy[i] = s[i];
            }

            s = copy;
        }

        public string Pop()
        {
            // avoid "loitering" so GC can reclaim memory if no outstanding references
            string item = s[--N];
            s[N] = null;

            // Don't want to do when half full because of "thrashing"
            if (N > 0 && N == s.Length / 4) Resize(s.Length / 2);

            return item;
        }
    }
}
