using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class RemoveDupesInPlace
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }

        //static void Main(string[] args)
        //{
        //    int[] nums = new int[] { 0, 1, 1, 1, 2, 2, 3, 4, 4 };

        //    Console.WriteLine(RemoveDuplicates(nums));
        //    Console.ReadLine();
        //}
    }
}
