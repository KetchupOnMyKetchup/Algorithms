using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.CTCI
{
    /// <summary>
    /// Given two arrays of integers, compute the pair of values (one value in each
    /// array) with the smallest(non-negative) difference.Return the difference.
    /// </summary>
    class _16_6SmallestDifference
    {
        static void FindSmallestDifference(int[] array1, int[] array2)
        {
            // brute force: iterate over each and get the differences, N^2
            // could sort arrays
            // dictionary tag which array its from, and combine into 1 array. sort. get 2 that are closest to each other.
            
            // { 1, 2, 3, 11, 15 }
            Array.Sort(array1);

            // { 8, 19, 23, 127, 235 }
            Array.Sort(array2);

            int min = 0;
            int difference = 0;

            int a = 0;
            int b = 0;

            while (a < array1.Length && b < array2.Length)
            {
                if (Math.Abs(array1[a] - array2[b]) < difference)
                {
                    difference = Math.Abs(array1[a] - array2[b]);
                }

                // Move smaller value
                if (array1[a] < array2[b]) a++;
                else b++;
            }

            Console.WriteLine($"Minimum difference is {min}");
        }

        //static void Main()
        //{
        //    int[] array1 = new int[] { 1, 3, 15, 11, 2 };
        //    int[] array2 = new int[] { 23, 127, 235, 19, 8 };

        //    FindSmallestDifference(array1, array2);
        //}
    }
}
