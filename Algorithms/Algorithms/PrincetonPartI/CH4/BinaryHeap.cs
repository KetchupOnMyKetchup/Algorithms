using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH4
{
    /// <summary>
    /// Heap on the other hand follows just one property, For Min-heap, all the elements in the child (both left and right) should be greater than the root value.
    /// And for Max-heap, all the elements in the child(both left and right) should be less than the root value.
    /// Max value at top. Top = 1 in this case, no 0 index. 
    /// Add node at end of tree, swim it up (1 + lg N compares)
    /// Delete max: exchange top with bottom, remove max from bottom. Swim top back down. 
    /// Can create a Min Priority Queue as well, replace less() with greater()
    /// </summary>
    public class BinaryHeap<TKey> where TKey : IComparable<TKey> // AKA Priority Queue
    {
        private TKey[] pq;
        private int N;

        public BinaryHeap(int capacity)
        {
            //pq = (TKey[])new IComparable[capacity + 1];
            // TODO check
            new List<TKey>[capacity + 1].CopyTo(pq, 0);
        }

        public bool isEmpty(){ return N == 0; }

        public void insert(TKey key)
        {
            pq[++N] = key;
            swim(N);
        }

        public TKey delMax()
        {
            TKey max = pq[1];
            exch(1, N--);
            sink(1);
            pq[N + 1] = default(TKey);
            return max;
        }

        private void swim(int k) // Swim Up
        {
            while (k > 1 && less(k / 2, k))
            {
                exch(k, k / 2);
                k = k / 2;
            }
        }

        private void sink(int k) // Sink down
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && less(j, j + 1)) j++;
                if (!less(k, j)) break;
                exch(k, j);
                k = j;
            }
        }

        private bool less(int i, int j)
        {
            return pq[i].CompareTo(pq[j]) < 0;
        }

        private void exch(int i, int j)
        {
            TKey t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;
        }
    }
}
