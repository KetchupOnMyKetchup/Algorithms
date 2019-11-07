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
            if (nums.Length == 0) return 0;
            
            int pointer = nums.Length - 1;
            int i = 0;

            while (i < pointer)
            {
                if (nums[i] == val)
                {
                    while (nums[pointer] == val) pointer--;

                    var temp = nums[i];
                    nums[i] = nums[pointer];
                    nums[pointer] = temp;
                }

                i++;
            }

            return i;
        }
    }
}
