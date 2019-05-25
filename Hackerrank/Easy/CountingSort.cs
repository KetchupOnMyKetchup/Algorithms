using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank.Easy
{
    class CountingSort
    {
        static int[] countingSort(int[] arr)
        {
            var result = new int[100];

            foreach (var item in arr)
            {
                result[item]++;
            }

            return result;
        }

        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //    int[] result = countingSort(arr);
        //}
    }
}
