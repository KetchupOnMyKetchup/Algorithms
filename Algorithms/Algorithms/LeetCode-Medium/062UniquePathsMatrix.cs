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
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[7];
            jaggedArray[1] = new int[7];
            jaggedArray[2] = new int[7];
        }
    }
}
