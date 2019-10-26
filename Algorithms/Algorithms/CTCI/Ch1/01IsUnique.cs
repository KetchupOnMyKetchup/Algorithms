using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    class _01IsUnique
    {
        // Implement an algorithm to determine if a string has all unique characters. What if you
        // cannot use additional data structures
        public static bool UniqueChar(string input)
        {
            // hashset if can use additional data structures
            // sort in place, see if same as previous one

            var sortedInput = input.ToCharArray();

            QuickSort(sortedInput, 0, input.Length - 1);

            for (int i = 1; i < sortedInput.Length; i++)
            {
                if (sortedInput[i] == sortedInput[i - 1])
                {
                    return false;
                }
                    
            }

            return true;
        }
        static void QuickSort<T>(T[] arr, int low, int high) where T : IComparable<T>
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = Partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        static int Partition<T>(T[] arr, int low, int high) where T : IComparable<T>
        {
            //Console.WriteLine("Array is:");

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            T pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j].CompareTo(pivot) < 0)
                {
                    i++;

                    //Console.WriteLine($"i = {i} and arr[i] = {arr[i]}");
                    //Console.WriteLine($"j = {j} and arr[j] = {arr[j]}");

                    // swap arr[i] and arr[j] 
                    Exch(ref arr[i], ref arr[j]);
                    //Exch(arr, i, j);
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Exch(ref arr[i + 1], ref arr[high]);
            //Exch(arr, i + 1, high);

            return i + 1;
        }

        private static void Exch<T>(ref T i, ref T j)
        {
            T temp = i;
            i = j;
            j = temp;
        }

        private static void Exch<T>(T[] arr, int i, int j) where T : IComparable<T>
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        //private static void Quick_Sort <T>(T[] arr, int left, int right) where T : IComparable<T>
        //{
        //    if (left < right)
        //    {
        //        int pivot = Partition(arr, left, right);
        //        if (pivot > 1) Quick_Sort(arr, left, pivot - 1);
        //        if (pivot + 1 < right) Quick_Sort(arr, pivot + 1, right);
        //    }

        //}

        //private static int Partition<T>(T[] arr, int left, int right) where T : IComparable<T>
        //{
        //    T pivot = arr[left];
        //    while (true)
        //    {
        //        while (arr[left].CompareTo(pivot) < 0) left++;
        //        while (arr[right].CompareTo(pivot) > 0) right--;

        //        if (left < right)
        //        {
        //            T temp = arr[left];
        //            arr[left] = arr[right];
        //            arr[right] = temp;
        //        }
        //        else return right;
        //    }
        //}

        //public static void Main()
        //{
        //    //string input = "ahkjidhikjas";
        //    //int[] input = new int[] { 5, 4, 3, 2, 1 };
        //    int[] input = new int[] { 1, 5, 8, 3, 2, 4 };
        //    //Console.WriteLine(UniqueChar(input));
        //    QuickSort(input, 0, input.Length - 1);
        //    Console.ReadLine();
        //}
    }
}
