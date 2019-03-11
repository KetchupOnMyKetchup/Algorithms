using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank.Easy
{
    class InsertionSort1
    {
        // https://www.hackerrank.com/challenges/insertionsort1/problem
        static void insertionSort1(int n, int[] arr)
        {
            int lastIndex = arr.Length - 1;
            int lastNum = arr[lastIndex];

            for (int i = lastIndex - 1; i >= 0; i--)
            {
                if (lastNum < arr[i])
                {
                    arr[i + 1] = arr[i];
                    Console.WriteLine("{0}", string.Join(" ", arr));
                }
                else
                {
                    arr[i + 1] = lastNum;
                    Console.WriteLine("{0}", string.Join(" ", arr));
                    return;
                }
            }

            arr[0] = lastNum;
            Console.WriteLine("{0}", string.Join(" ", arr));
        }

        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //    insertionSort1(n, arr);
        //}
    }
}
