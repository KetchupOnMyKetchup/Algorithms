using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/diagonal-difference/problem
    public class DiagonalDifference
    {
        static int DiagonalDifference_Problem(int[][] arr)
        {
            int sizeOfArray = arr.Count();

            // top left to bottom right
            int topLeftToBottomRight = 0;

            for (int i = 0; i < sizeOfArray; i++)
            {
                topLeftToBottomRight += arr[i][i];
            }

            // top right to bottom left 

            int x = 0;

            int topRightToBottomLeft = 0;

            for (int y = sizeOfArray - 1; y >= 0; y--)
            {
                topRightToBottomLeft += arr[x][y];

                x++;
            }

            // absolute difference
            return Math.Abs(topLeftToBottomRight - topRightToBottomLeft);
        }

        // Insert into console 
        // 1 2 3 (hit enter)
        // 4 5 6 (hit enter)
        // 7 8 9 (hit enter)
        // you can change int n = 3 to another value to make it larger

        //static void Main(string[] args)
        //{
        //    int n = 3;

        //    int[][] arr = new int[n][];

        //    for (int i = 0; i < n; i++)
        //    {
        //        arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //    }

        //    int result = diagonalDifference(arr);
        //}
    }
}
