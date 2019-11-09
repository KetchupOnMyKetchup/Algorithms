using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _062UniquePathsMatrix
    {
        public static void Main()
        {
            int result = UniquePaths(3, 2);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int UniquePaths(int m, int n)
        {
            int[][] jaggedArray = new int[m][];

            for (int i = 0; i < m; i++)
            {
                jaggedArray[i] = new int[n];
            }

            return 0;
        }
    }
}
