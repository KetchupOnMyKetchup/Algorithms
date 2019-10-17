using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    class _08ZeroMatrix
    {
        private static object ZeroMatrix(int[][] matrix)
        {
            throw new NotImplementedException();
        }

        public static void Main()
        {
            int[][] matrix = new int[3][]
            {
                new int[] { 1, 2 , 3},
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            var result = ZeroMatrix(matrix);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
