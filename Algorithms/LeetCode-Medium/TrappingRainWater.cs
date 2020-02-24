using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode_Medium
{
    class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            int sum = 0;
            int left = 0, right = height.Length - 1;
            int maxLeft = 0, maxRight = 0;

            while (left < right)
            {
                maxLeft = Math.Max(maxLeft, height[left]);
                maxRight = Math.Max(maxRight, height[right]);

                if (maxLeft < maxRight)
                {
                    sum += maxLeft - height[left++];
                }
                else
                {
                    sum += maxRight - height[right--];
                }
            }

            return sum;
        }
    }
}
