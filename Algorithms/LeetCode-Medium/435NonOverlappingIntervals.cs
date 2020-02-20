using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    /// <summary>
    /// Greedy Algorithm -- not an algo, its a technique
    /// https://en.wikipedia.org/wiki/Interval_scheduling#Interval_Scheduling_Maximization
    /// 1. Select the interval, x, with the earliest finishing time.
    //  2. Remove x, and all intervals intersecting x, from the set of candidate intervals.
    //  3. Repeat until the set of candidate intervals is empty.
    /// </summary>
    class _435NonOverlappingIntervals
    {
        //public static void Main()
        //{
        //    int[][] intervals = new int[4][]
        //    {
        //        new int[] { 1, 2 },
        //        new int[] { 2, 3 },
        //        new int[] { 3, 4 },
        //        new int[] { 1, 3 }
        //    };
        //    var result = EraseOverlapIntervals(intervals);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        public static int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals.Length == 0) return 0;
            
            Array.Sort(intervals, new MyComparator());
            int end = intervals[0][1];
            int count = 1;

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] >= end)
                {
                    end = intervals[i][1];
                    count++;
                }
            }

            return intervals.Length - count;
        }
    }
    class MyComparator : Comparer<int[]>
    {
        public override int Compare(int[] x, int[] y)
        {
            return x[1].CompareTo(y[1]);
            //return x[1] - y[1];
        }
    }
}
