using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] + nums[i] > nums[i])
                {
                    nums[i] += nums[i - 1];
                }
            }
            return nums.Max();
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        //    Console.ReadLine();
        //}
    }
}
