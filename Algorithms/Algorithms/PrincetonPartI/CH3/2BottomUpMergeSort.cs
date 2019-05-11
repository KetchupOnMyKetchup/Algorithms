using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH3
{
    /// <summary>
    /// Simple and non-recursive version of mergesort. But about 10% slower than recursive, top-down mergesort on typical systems
    /// Divide array little subarrays of size 1
    /// Merge into little sorted subarrays of size 2
    /// Then keep merging up into sorted subarrays of size 4, 6, 16, and so on until you have 1 sorted array. 
    /// </summary>
    public class BottomUpMergeSort
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
        public static void sort(IComparable[] a)
        {
            int N = a.Length;
            IComparable[] aux = new IComparable[N];
            for (int sz = 1; sz < N; sz = sz + sz)
                for (int lo = 0; lo < N - sz; lo += sz + sz)
                    merge(a, aux, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
        }

        private static bool less(IComparable v, IComparable w)
        { return v.CompareTo(w) < 0; }
    }
}
