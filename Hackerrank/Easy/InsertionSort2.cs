using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank.Easy
{
    class InsertionSort2
    {
        static void insertionSort2(int n, int[] arr)
        {
            int lastIndex = n - 1;
            int lastNum = arr[lastIndex];

            for (int i = 1; i <= lastIndex; i++)
            {
                TestLowerArrayIndexes(arr, i);
                Console.WriteLine("{0}", string.Join(" ", arr));
            }
        }

        private static void TestLowerArrayIndexes(int[] arr, int startIndex)
        {
            int i = startIndex - 1;
            while (i >= 0 && arr[startIndex] < arr[i]) i--;
            if (i == startIndex - 1) return;

            // Lift value that needs to be moved
            int valueToSave = arr[startIndex];

            // Shift Right
            for (int j = startIndex; j > i + 1; j--) arr[j] = arr[j - 1];

            arr[i + 1] = valueToSave;
        }

        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //    insertionSort2(n, arr);
        //}
    }
}
