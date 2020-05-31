using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode_Medium
{
    class _240Search2DMatrix
    {
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            int row = matrix.GetLength(0) - 1;
            int col = 0;

            while (row >= 0 && col < matrix.GetLength(1))
            {
                if (matrix[row, col] > target) row--;
                else if (matrix[row, col] < target) col++;
                else return true;
            }

            return false;
        }

        //static void Main()
        //{
        //    int[,] matrix = new int[,]
        //    {
        //        { 1,4,7,11,15 },
        //        { 2,5,8,12,19 },
        //        { 3,6,9,16,22 },
        //        { 10,13,14,17,24 },
        //        { 18,21,23,26,30 }
        //    };

        //    var results = SearchMatrix(matrix, 8);
        //    Console.WriteLine(results);
        //    Console.ReadLine();
        //}
    }
}
