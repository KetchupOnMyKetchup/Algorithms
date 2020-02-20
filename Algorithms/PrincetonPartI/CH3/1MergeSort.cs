using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH3
{
    /// <summary>
    /// Divide array into 2 halves
    /// copy into auxillary array
    /// Recursively sort each half
    /// Merge two halves
    /// Speed: N log N compares and 6 N log N array accesses to sort any array of size N 
    /// 10^8 compares/second on laptop, 10^12 compares/second on supercomputer
    /// </summary>
    public class MergeSort
    {
        private static void merge(IComparable[] a, IComparable[] aux, int lo, int mid, int hi)
        {
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) aux[k] = a[j++];
                else if (j > hi) aux[k] = a[i++];
                else if (less(a[j], a[i])) aux[k] = a[j++];
                else aux[k] = a[i++];
            }
        }
        private static void sort(IComparable[] a, IComparable[] aux, int lo, int hi)
        {
            if (hi <= lo) return;
            int mid = lo + (hi - lo) / 2;
            sort(aux, a, lo, mid);
            sort(aux, a, mid + 1, hi);
            merge(a, aux, lo, mid, hi);
        }

        private static bool less(IComparable v, IComparable w)
        { return v.CompareTo(w) < 0; }
    }
}
