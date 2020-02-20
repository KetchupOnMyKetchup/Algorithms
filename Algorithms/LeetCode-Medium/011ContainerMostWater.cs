using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _011ContainerMostWater
    {
        private static int MaxArea(int[] height)
        {
            int l = 0;
            int r = height.Length - 1;
            int maxArea = 0;

            while (l < r)
            {
                maxArea = Math.Max(maxArea, (r - l) * Math.Min(height[l], height[r]));

                if (height[l] < height[r]) l++;
                else r--;
            }

            return maxArea;
        }

        //public static void Main()
        //{
        //    //int[] heights = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        //    int[] heights = new int[] { 1, 1 };

        //    Console.WriteLine(MaxArea(heights));
        //    Console.ReadLine();
        //}
    }
}
