using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI
{
    /// <summary>
    /// 1. Randomly shuffle (to guarantee performance)
    /// 2. Partition so that for a random spot "j" that everything to the left is less, and right is more.
    ///    Try to get a "j" that will be close to the middle. 
    ///    It partitions in place. If you use an extra array it makes partitioning easier/more stable but is not worth the cost of space for the 2nd array.  
    /// 3. Sort recursively
    /// Worst case: 1/2 N^2
    /// Avg case: 1.39 N log N
    /// Is not "stable" with default implementation, but can be made so. 
    /// Too much overhead for small subarrys. Do insertion sort for smaller arrays (10 or less items)
    /// </summary>
    public class QuickSort
    {
        public static void sort(IComparable[] a)
        {
            Randomize(a);
            //StdRandom.shuffle(a);
            sort(a, 0, a.Length - 1);
        }

        private static void sort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int j = partition(a, lo, hi);
            sort(a, lo, j - 1);
            sort(a, j + 1, hi);
        }

        private static int partition(IComparable[] a, int lo, int hi)
        {
            int i = lo, j = hi + 1;
            while (true)
            {
                while (less(a[++i], a[lo]))
                    if (i == hi) break;
                while (less(a[lo], a[--j]))
                    if (j == lo) break;
                if (i >= j) break;
                exch(a, i, j);
            }
            exch(a, lo, j);
            return j;
        }

        private static bool less(IComparable v, IComparable w)
        { return v.CompareTo(w) < 0; }

        private static void exch(IComparable[] a, int i, int j)
        {
            IComparable swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }
        private static void Randomize<T>(T[] items)
        {
            Random rand = new Random();

            // For each spot in the array, pick
            // a random item to swap into that spot.
            for (int i = 0; i < items.Length - 1; i++)
            {
                int j = rand.Next(i, items.Length);
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }
    }
}
