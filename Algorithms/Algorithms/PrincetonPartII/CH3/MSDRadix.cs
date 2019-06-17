using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH3
{
    /// <summary>
    /// Much too slow for small subarrays.
    /// Huge number of small subarrays because of recursion.
    /// Cutoff to insertion sort for small subarrays.
    /// </summary>
    class MSDRadix
    {
        //public static void sort(String[] a)
        //{
        //    var aux = new String[a.Length];
        //    sort(a, aux, 0, a.Length - 1, 0);
        //}
        //private static void sort(String[] a, String[] aux, int lo, int hi, int d)
        //{
        //    if (hi <= lo) return;
        //    int[] count = new int[R + 2];
        //    for (int i = lo; i <= hi; i++)
        //        count[charAt(a[i], d) + 2]++;
        //    for (int r = 0; r < R + 1; r++)
        //        count[r + 1] += count[r];
        //    for (int i = lo; i <= hi; i++)
        //        aux[count[charAt(a[i], d) + 1]++] = a[i];
        //    for (int i = lo; i <= hi; i++)
        //        a[i] = aux[i - lo];
        //    for (int r = 0; r < R; r++)
        //        sort(a, aux, lo + count[r], lo + count[r + 1] - 1, d + 1);
        //}
    }
}
