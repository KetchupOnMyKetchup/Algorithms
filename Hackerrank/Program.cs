using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Algorithms.Algorithms.PrincetonPartI;

namespace Hackerrank
{
    class Program
    {
        static int findMedian(int[] arr)
        {
            sort(arr, 0, arr.Length - 1);
            return arr[arr.Length / 2];
        }

        private static void sort(int[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int j = partition(a, lo, hi);
            sort(a, lo, j - 1);
            sort(a, j + 1, hi);
        }

        private static int partition(int[] a, int lo, int hi)
        {
            int i = lo, j = hi + 1;
            while (true)
            {
                while (less(a[++i], a[lo]))
                    if (i == hi) break;
                while (less(a[lo], a[--j]))
                    if (j == lo) break;
                if (i >= j) break;
                exch(a, i, j);
            }
            exch(a, lo, j);
            return j;
        }

        private static bool less(int v, int w)
        { return v.CompareTo(w) < 0; }

        private static void exch(int[] a, int i, int j)
        {
            int swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int result = findMedian(arr);
        }
    }

}
