using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode_Medium
{
    class _048RotateImage
    {
        //public static void Main()
        //{
        //    int[][] matrix = new int[3][]
        //    {
        //        new int []{1, 2, 3 },
        //        new int []{4, 5, 6 },
        //        new int []{7, 8, 9 }
        //    };

        //    Rotate(matrix);
        //}

        // B2B video, 12:00 https://codinginterviewclass.com/courses/633601/lectures/12667503
        // https://www.tutorialspoint.com/cprogramming/images/two_dimensional_arrays.jpg
        public static void Rotate(int[][] matrix)
        {
            int size = matrix.Length - 1;

            for (int layer = 0; layer < matrix.Length / 2; layer++)
            {
                for (int i = layer; i < size - layer; i++)
                {
                    // matrix[row][col]
                    
                    // col is moving so i
                    int top = matrix[layer][i];

                    // row is going up and down
                    int right = matrix[i][size - layer];

                    // col is moving - i
                    int bottom = matrix[size - layer][size - i];

                    // row is going down to up
                    int left = matrix[size - i][layer];

                    matrix[layer][i] = left;
                    matrix[size - i][layer] = bottom;
                    matrix[size - layer][size - i] = right;
                    matrix[i][size - layer] = top;
                }
            }
        }













        //public static void Rotate(int[][] matrix)
        //{
        //    int size = matrix.Length - 1;

        //    for (int layer = 0; layer < matrix.Length / 2; layer++) // layer 0 = outermost
        //    {
        //        for (int i = layer; i < size - layer; i++)
        //        {
        //            // matrix[row.. up & down][column.. left & right]

        //            // row stays same, column goes left to right.. so i
        //            int topL = matrix[layer][i];

        //            // row goes up and down, column stays same and is last column.. so size - layer
        //            int topR = matrix[i][size - layer];

        //            // row stays same and is last so size - layer, column changes left to right  so size - i
        //            int bottomR = matrix[size - layer][size - i];

        //            // row goes down to up so size - i, column stays same as first column so layer
        //            int bottomL = matrix[size - i][layer];

        //            matrix[layer][i] = bottomL;
        //            matrix[size - i][layer] = bottomR;
        //            matrix[size - layer][size - i] = topR;
        //            matrix[i][size - layer] = topL;
        //        }
        //    }
        //}

        //public static void Rotate(int[][] matrix)
        //{
        //    int n = matrix.Length;
        //    int l = n - 1;

        //    for (int i = 0; i < (n + 1) / 2; i++) // i stops at 2
        //    {
        //        for (int j = 0; j < n / 2; j++) // j stops at 1
        //        {
        //            int temp = matrix[l - j][i]; // bottom left
        //            matrix[l - j][i] = matrix[l - i][l - j]; // bottom left = bottom right
        //            matrix[l - i][l - j] = matrix[j][l - i]; // bottom right = top right
        //            matrix[j][l - i] = matrix[i][j];    // top right = top left
        //            matrix[i][j] = temp;     // top left = bottom left
        //        }
        //    }

        //}
    }
}
