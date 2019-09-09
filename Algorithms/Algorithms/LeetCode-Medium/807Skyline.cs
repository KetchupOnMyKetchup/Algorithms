using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _807Skyline
    {
        public static int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int N = grid.Length;
            int[] rowMaxes = new int[N];
            int[] colMaxes = new int[N];

            for (int r = 0; r < N; ++r)
                for (int c = 0; c < N; ++c)
                {
                    rowMaxes[r] = Math.Max(rowMaxes[r], grid[r][c]);
                    colMaxes[c] = Math.Max(colMaxes[c], grid[r][c]);
                }

            int ans = 0;
            for (int r = 0; r < N; ++r)
                for (int c = 0; c < N; ++c)
                    ans += Math.Min(rowMaxes[r], colMaxes[c]) - grid[r][c];

            return ans;
        }

        static void Main(string[] args)
        {
            // Multidimensional array initialization
            //int[,] grid = new int[,] 
            //{ 
            //    { 3, 0, 8, 4 }, 
            //    { 2, 4, 5, 7 }, 
            //    { 9, 2, 6, 3 }, 
            //    { 0, 3, 1, 0 }
            //};

            // Jagged array initialization
            int[][] grid = new int[][]
            {
                new int[] { 3, 0, 8, 4 },
                new int[] { 2, 4, 5, 7 },
                new int[] { 9, 2, 6, 3 },
                new int[] { 0, 3, 1, 0 }
            };

            Console.WriteLine(MaxIncreaseKeepingSkyline(grid).ToString());
            Console.ReadLine();
        }
    }
}
