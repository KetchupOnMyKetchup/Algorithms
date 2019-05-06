using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH2
{
    /// <summary>
    /// 1st card: compare card to card on the right so in ascending order.
    /// 2nd and onwards: compare with card(s) to the left, swap until in ascending order. 
    /// pointer scans left to right
    /// ~1/4 N^2 compares and ~1/4 N^2 exchanges on average
    /// Best case: N-1 compares and 0 exchanges (better than a selction sort)
    /// Worst case: ~1/2 N^2 compares and ~1/2 N^2 exchanges (worse than a selection sort)
    /// </summary>
    public class InsertionSort
    {
        public static void Sort(IComparable[] a)
        {
            int N = a.Length;

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < 0; j--)
                {
                    if (less(a[j], a[j - 1]))
                    exch(a, j, j - 1);
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
