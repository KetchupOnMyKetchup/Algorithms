using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    /// <summary>
    /// https://www.interviewbit.com/tutorial/merge-sort-algorithm/
    /// </summary>
    class MergeSortA
    {
        static void MergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSort(arr, start, mid);
                MergeSort(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }

        static void Merge(int[] arr, int start, int mid, int end)
        {
            // create a temp array
            int[] temp = new int[end - start + 1];

            // crawlers for both intervals and for temp
            int i = start, j = mid + 1, k = 0;

            // traverse both arrays and in each iteration add smaller of both elements in temp 
            while (i <= mid && j <= end)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    k += 1; i += 1;
                }
                else
                {
                    temp[k] = arr[j];
                    k += 1; j += 1;
                }
            }

            // add elements left in the first interval 
            while (i <= mid)
            {
                temp[k] = arr[i];
                k += 1; i += 1;
            }

            // add elements left in the second interval 
            while (j <= end)
            {
                temp[k] = arr[j];
                k += 1; j += 1;
            }

            // copy temp to original interval
            for (i = start; i <= end; i += 1)
            {
                arr[i] = temp[i - start];
            }
        }

        //public static void Main()
        //{
        //    //string input = "ahkjidhikjas";
        //    //int[] input = new int[] { 5, 4, 3, 2, 1 };
        //    int[] input = new int[] { 1, 5, 8, 3, 2, 4 };
        //    //Console.WriteLine(UniqueChar(input));
        //    MergeSort(input, 0, input.Length - 1);
        //    Console.ReadLine();
        //}
    }
}
