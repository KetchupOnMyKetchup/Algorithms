using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH2
{
    /// <summary>
    /// </summary>
    public class FixedCapacityStackGeneric<T> : IEnumerable<T>
    {
        private T[] s; 
        private int N = 0; 

        public FixedCapacityStackGeneric(int capacity)
        {
            s = new T[capacity];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public void Push(T item)
        {
            if (N == s.Length) Resize(2 * s.Length);

            s[N++] = item;
        }

        private void Resize(int capacity)
        {
            T[] copy = new T[capacity];

            for (int i = 0; i < N; i++)
            {
                copy[i] = s[i];
            }

            s = copy;
        }

        public T Pop()
        {
            // avoid "loitering" so GC can reclaim memory if no outstanding references
            T item = s[--N];
            s[N] = default(T);

            // Don't want to do when half full because of "thrashing"
            if (N > 0 && N == s.Length / 4) Resize(s.Length / 2);

            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //return s.GetEnumerator();
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
