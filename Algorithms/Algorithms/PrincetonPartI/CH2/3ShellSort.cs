using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH2
{
    /// <summary>
    /// https://www.youtube.com/watch?v=ddeLSDsYVp8
    /// Move entries more than 1 position at a time by 'h-sorting' the array
    /// Insertion sort, but with stride length "h".
    /// Which increment?
    /// 3x + 1 = good
    /// 1, 5, 19, 41, 109, 209, 505, 929, 2161, 3905.. really good (Sedgewick)
    /// worst-case number of compares used by shellsort with the 3x+1 increments is O(N 3/2).
    /// </summary>
    public class ShellSort // 3x + 1 Implementation
    {
        public static void Sort(IComparable[] a)
        {
            int N = a.Length;

            int h = 1;
            while (h < N / 3) h = 3 * h + 1; // 3x + 1 Implementation

            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h && less(a[j], a[j - h]); j -= h)
                        exch(a, j, j - h);
                }
            }

            h /= 3;
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
