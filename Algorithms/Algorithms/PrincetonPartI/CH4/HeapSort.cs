using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH4
{
    public class HeapSort
    {
        public static void sort(IComparable[] a)
        {
            int N = a.Length;
            for (int k = N / 2; k >= 1; k--)
                sink(a, k, N);
            while (N > 1)
            {
                exch(a, 1, N);
                sink(a, 1, --N);
            }
        }

        private static void sink(IComparable[] a, int k, int N) // Sink down
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && less(a, j, j + 1)) j++;
                if (!less(a, k, j)) break;
                exch(a, k, j);
                k = j;
            }
        }

        private static bool less(IComparable[] a, int i, int j)
        {
            return a[i].CompareTo(a[j]) < 0;
        }

        private static void exch(IComparable[] a, int i, int j)
        {
            var t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
    }
}
