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
        private IComparable[] _array;

        public void sort(IComparable[] a)
        {
            this._array = a;

            Randomize();
            //StdRandom.shuffle(a);
            sort(0, a.Length - 1);
        }

        private void sort(int lo, int hi)
        {
            if (hi <= lo) return;

            int j = partition(lo, hi);
            sort(lo, j - 1); // recursive
            sort(j + 1, hi); // recursive
        }

        private int partition(int lo, int hi)
        {
            int i = lo, j = hi + 1;
            while (true) // infinite while loop
            {
                while (less(_array[++i], _array[lo]))
                    if (i == hi) break;

                while (less(_array[lo], _array[--j]))
                    if (j == lo) break;

                if (i >= j) break;
                exch(i, j);
            }
            exch(lo, j);
            return j;
        }

        private bool less(IComparable i, IComparable j)
        {
            // if i is less than j, then its negative 
            return i.CompareTo(j) < 0;
        }

        private void exch(int i, int j)
        {
            IComparable swap = _array[i];
            _array[i] = _array[j];
            _array[j] = swap;
        }
        private void Randomize()
        {
            Random rand = new Random();

            for (int i = 0; i < _array.Length - 1; i++)
            {
                int j = rand.Next(i, _array.Length);
                exch(i, j);
            }
        }
    }
}
