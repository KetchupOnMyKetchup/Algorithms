using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _062UniquePathsMatrix
    {
        //public static void Main()
        //{
        //    int result = UniquePaths(3, 2);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        private static int UniquePaths(int m, int n)
        {
            // m is width, n is height
            int[,] arr = new int[m,n];

            for (int i = 0; i < m; i++)
            {
                arr[i,0] = 1;
            }

            for (int j = 0; j < n; j++)
            {
                arr[0, j] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    arr[i, j] = arr[i - 1, j] + arr[i, j - 1];
                }
            }

            return arr[m - 1, n - 1];
        }
    }
}
