using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH2
{
    /// <summary>
    /// find smallest entry in array, swap it to leftmost position.
    /// find next smallest to the right of the sorted smallest item, etc.
    /// finding that minimum item is a pain. quadratic compares even if input array is already sorted (double for loops)
    /// pointer scans left to right
    /// ~N^2 / 2 compares and exactly N exchanges
    /// </summary>
    public class SelectionSort
    {
        public static void Sort(IComparable[] a)
        {
            int N = a.Length;

            for (int i = 0; i < N; i++)
            {
                int min = i;

                for (int j = 0; j < i + 1; j++)
                {
                    if (less(a[j], a[min])) min = j;

                    exch(a, i, min);
                }
            }
        }

        private static bool less(IComparable v, IComparable w)
        { return v.CompareTo(w) < 0; }

        private static void exch(IComparable[] a, int i, int j)
        {
            IComparable swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }
    }
}
