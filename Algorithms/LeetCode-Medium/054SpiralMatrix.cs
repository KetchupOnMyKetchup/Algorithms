using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode_Medium
{
    class _054SpiralMatrix
    {
        //public static void Main()
        //{
        //    int[][] matrix = new int[4][]
        //    {
        //        new int []{1, 2, 3 },
        //        new int []{4, 5, 6 },
        //        new int []{7, 0, 9 },
        //        new int []{7, 8, 9 }
        //    };

        //    SpiralOrder(matrix);
        //}

        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();

            if (matrix.Length == 0) return result;

            int r1 = 0;
            int c1 = 0;
            int r2 = matrix.Length - 1;
            int c2 = matrix[0].Length - 1;

            while (r1 <= r2 && c1 <= c2)
            {
                for (int c = c1; c <= c2; c++) result.Add(matrix[r1][c]); // handles 5
                for (int r = r1 + 1; r <= r2; r++) result.Add(matrix[r][c2]); // handles 0

                if (r1 < r2 && c1 < c2) // only go into this if there's a bottom half
                {
                    for (int c = c2 - 1; c > c1; c--) result.Add(matrix[r2][c]);
                    for (int r = r2; r > r1; r--) result.Add(matrix[r][c1]);
                }

                r1++;
                c1++;
                r2--;
                c2--;
            }

            return result;
        }

    }
}
