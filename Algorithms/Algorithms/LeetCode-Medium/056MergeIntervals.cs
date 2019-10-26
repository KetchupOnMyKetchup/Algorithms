using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _056MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> list = new List<int[]>();

            if (intervals.Length > 0)
            {
                Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

                //for (int i = 1; i < intervals.Length; i++)
                //{
                //    for (int j = i; j > 0; j--)
                //    {
                //        if (intervals[j][0] < intervals[j - 1][0])
                //        {
                //            var temp = intervals[j - 1];
                //            intervals[j - 1] = intervals[j];
                //            intervals[j] = temp;
                //        }
                //    }
                //}

                list.Add(intervals[0]);
            }

            for (int i = 1; i < intervals.Length; i++)
            {
                var intervalLeft = list[list.Count - 1]; // ^1 is the same in C# 8
                var intervalRight = intervals[i];

                if (intervalLeft[1] >= intervalRight[0])
                {
                    if (intervalLeft[1] < intervalRight[1])
                    {
                        intervalLeft[1] = intervalRight[1];
                    }
                }
                else
                {
                    list.Add(intervalRight);
                }
            }

            return list.ToArray();
        }

        //public static void Main()
        //{
        //    int[][] jaggedArray = new int[][]
        //    {
        //        new int[] { 1, 3 },
        //        new int[] { 8, 10 },
        //        new int[] { 2, 6 },
        //        new int[] { 15, 18 }
        //    };

        //    var result = Merge(jaggedArray);
        //    Console.ReadLine();
        //}
    }
}
