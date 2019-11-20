using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _027RemoveElement
    {

        //public static void Main()
        //{
        //    int[] nums = new int[] { 2 };
        //    int val = 3;
        //    int result = RemoveElement(nums, val);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        private static int RemoveElement(int[] nums, int val)
        {
           
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    n--;
                }
                else
                {
                    i++;
                }
            }
            return n;
        }
    }
}
