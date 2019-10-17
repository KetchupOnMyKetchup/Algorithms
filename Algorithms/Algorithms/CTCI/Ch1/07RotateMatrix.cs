using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    /// <summary>
    /// p. 215
    /// This algorithm is O(N^2), which is the best we can do since any algorithm must touch all N2 elements.
    /// </summary>
    class _07RotateMatrix
    {
        private static int[][] RotateMatrix(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix.Length != matrix[0].Length) return matrix;
            int n = matrix.Length;

            for (int layer = 0; layer < n / 2; layer++)
            {
                int last = n - 1 - layer;

                for (int i = layer; i < last; i++)
                {
                    int offset = i - layer; // corners, then 1 in, then 2 in, etc.

                    // top = temp
                    int temp = matrix[layer][i];

                    // Top left = bottom left
                    matrix[layer][i] = matrix[last - offset][layer];
                    // Bottom left = bottom right
                    matrix[last - offset][layer] = matrix[last][last - offset];
                    // Bottom right = top right
                    matrix[last][last - offset] = matrix[i][last];
                    // Top right = temp
                    matrix[i][last] = temp;
                }
            }

            return matrix;
        }

        //public static void Main()
        //{
        //    int[][] matrix = new int[3][] 
        //    {
        //        new int[] { 1, 2 , 3},
        //        new int[] { 4, 5, 6 },
        //        new int[] { 7, 8, 9 }
        //    };

        //    var result = RotateMatrix(matrix);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
    }
}
