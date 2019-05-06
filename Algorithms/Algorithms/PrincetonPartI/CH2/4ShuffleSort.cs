using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH2
{
    /// <summary>
    /// Regular shuffle
    /// Reasons to shuffle: random items on a shop, poker/card game websites
    /// </summary>
    public class ShuffleSort 
    {
        public static void Shuffle(IComparable[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                Random random = new Random();
                int r = random.Next(i + 1);
                //int r = StdRandom.uniform(i + 1);
                exch(a, i, r);
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
