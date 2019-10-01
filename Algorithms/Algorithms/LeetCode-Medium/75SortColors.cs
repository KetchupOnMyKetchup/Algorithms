using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _75SortColors
    {
        public static void SortColors(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (nums[j] < nums[j - 1]) Exch(nums, j - 1, j);
                    else break;
                }
            }
        }

        private static void Exch(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        //public static void Main()
        //{
        //    int[] myArr = new int[] { 2, 0, 2, 1, 1, 0 };

        //    SortColors(myArr);
        //    Console.ReadLine();
        //}
    }
}
