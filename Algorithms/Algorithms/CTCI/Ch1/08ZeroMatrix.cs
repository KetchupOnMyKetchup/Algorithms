using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    static class _08ZeroMatrix
    {
        private static object ZeroMatrix(int[][] matrix)
        {
            int[][] finalMatrix = new int[matrix.Length][];

            //TODO Finish later
            //for (int i = 0; i < finalMatrix.Length; i++)
            //{
            //    finalMatrix[i] = Enumerable. new int[matrix.Length];
            //}

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        NullifyRow(finalMatrix, i);
                        NullifyColumn(finalMatrix, j);
                    }
                    else
                    {
                        if (finalMatrix[i][j] != 0) finalMatrix[i][j] = matrix[i][j];
                    }
                }
            }

            return finalMatrix;
        }

        static void NullifyRow(int[][] matrix, int row)
        {
            for (int i = 0; i < matrix.Length; i++) matrix[row][i] = 0;
        }

        static void NullifyColumn(int[][] matrix, int col)
        {
            for (int i = 0; i < matrix.Length; i++) matrix[i][col] = 0;
        }

        //public static void Main()
        //{
        //    int[][] matrix = new int[3][]
        //    {
        //        new int[] { 1, 0 ,3 },
        //        new int[] { 4, 5, 6 },
        //        new int[] { 7, 8, 9 }
        //    };

        //    var result = ZeroMatrix(matrix);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
    }
}
