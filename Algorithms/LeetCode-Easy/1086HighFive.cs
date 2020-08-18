using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Algorithms.LeetCode_Easy
{
    class _1086HighFive
    {
        //public static void Main()
        //{
        //    int[][] input = new int[][]
        //        {
        //            new int[] { 1, 84 },
        //            new int[] { 1, 72 },
        //            new int[] { 1, 47 },
        //            new int[] { 1, 43 },
        //            new int[] { 1, 78 },
        //            new int[] { 2, 79 },
        //            new int[] { 2, 4 },
        //            new int[] { 2, 23 },
        //            new int[] { 2, 88 },
        //            new int[] { 2, 79 },
        //            new int[] { 3, 75 },
        //            new int[] { 3, 38 },
        //            new int[] { 3, 73 },
        //            new int[] { 3, 80 },
        //            new int[] { 3, 4 },

        //        };

        //    HighFive(input);
        //}

        public static int[][] HighFive(int[][] items)
        {
            Dictionary<int, SortedSet<int>> dict = new Dictionary<int, SortedSet<int>>();

            for (int i = 0; i < items.Length; i++)
            {
                // see if key exists, if so add to sorted set
                if (!dict.ContainsKey((items[i][0]))) dict.Add(items[i][0], new SortedSet<int>());

                // if not, add new key and new sorted set
                dict[items[i][0]].Add(items[i][1]);
            }

            int[][] jagged = new int[dict.Count][];

            // loop over dict 
            int index = 0;
            foreach (var entry in dict)
            {
                // add key, get 5 max and average of them
                int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += entry.Value.Max;
                    entry.Value.Remove(entry.Value.Max);
                }
                jagged[index++] = new int[] { entry.Key, sum / 5 };
            }

            return jagged;
        }
    }
}
