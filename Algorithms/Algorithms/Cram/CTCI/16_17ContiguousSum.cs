using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.CTCI
{
    /// <summary>
    /// You are given an array of integers (both positive and negative). Find the
    /// contiguous sequence with the largest sum. Return the sum.
    /// </summary>
    class _16_17ContiguousSum
    {
        static void FindSum(int[] array)
        {
            // if array is all negative, return highest #

            int max = 0;
            int curr = 0;
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                curr = array[i];

                int j = i;
                sum = 0; 

                while (j < array.Length)
                {
                    sum += array[j++];
                    if (sum > max) max = sum;
                }
            }

            Console.WriteLine($"Max is {max}");
        }


        //static void Main()
        //{
        //    int[] array = new int[] { 5, -3, 17, -20, -1, 4, 18  };

        //    FindSum(array);

        //    Console.ReadLine();
        //}
    }
}
