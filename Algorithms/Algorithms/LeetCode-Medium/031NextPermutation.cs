using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _031NextPermutation // harder than most mediums, more "tricky" type problem. not likely to show up
    {
        //static void Main()
        //{
        //    int[] nums = { 1, 3, 2 };
        //    int[] result = NextPermutation(nums);

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();
        //}

        private static int[] NextPermutation(int[] nums)
        {
            // from right to left, find first digit that is lower than previous numbers
            int i = nums.Length - 2;

            while (i > 0 && nums[i] >= nums[i + 1]) i--;

            // hold that digit as i.  swap i with digit greater than it but closest to it (to the right of i)
            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (j >= 0 && nums[j] <= nums[i]) j--;
                Swap(nums, i, j);
            }

            // reverse all elements after i
            Reverse(nums, i +1);

            return nums;
        }

        private static void Reverse(int[] nums, int start)
        {
            int i = start, j = nums.Length - 1;
            while (i < j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }
        }

        private static void Swap(int[] num, int i1, int i2)
        {
            int temp = num[i1];
            num[i1] = num[i2];
            num[i2] = temp;
        }
    }
}
