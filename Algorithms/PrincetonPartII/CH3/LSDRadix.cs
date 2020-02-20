using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH3
{
    class LSDRadix
    {
        public static void Sort(string[] a, int W)
        {
            int R = 256;

            int N = a.Length;

            string[] aux = new string[N];

            for (int d = W - 1; d >= 0; d--)
            {
                int[] count = new int[R + 1];
                for (int i = 0; i < N; i++)
                    count[a[i][d] + 1]++;
                for (int r = 0; r < R; r++)
                    count[r + 1] += count[r];
                for (int i = 0; i < N; i++)
                    aux[count[a[i][d]]++] = a[i];
                for (int i = 0; i < N; i++)
                    a[i] = aux[i];
            }
        }
    }
}
