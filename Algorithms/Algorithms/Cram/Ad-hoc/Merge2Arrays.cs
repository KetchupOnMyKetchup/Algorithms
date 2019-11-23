using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.Ad_hoc
{
    class Merge2Arrays
    {
        //static void Main(string[] args)
        //{
        //    int[] arr1 = { 1, 2, 7, 0, 0, 0 };
        //    int[] arr2 = { 3, 5, 8 };

        //    var results = MergeArrs(arr1, 3, arr2, 3);

        //    foreach (var item in results)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();
        //}

        private static int[] MergeArrs(int[] arr1, int length1, int[] arr2, int length2)
        {
            length1 -= 1;
            length2 -= 1;

            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                if (length2 < 0 || arr1[length1] > arr2[length2])
                {
                    arr1[i] = arr1[length1];
                    length1--;
                }
                else
                {
                    arr1[i] = arr2[length2];
                    length2--;
                }
            }

            return arr1;
        }
    }
}
