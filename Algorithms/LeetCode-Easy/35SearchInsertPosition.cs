using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class SearchInsertPosition
    {
        // Given a sorted array and a target value, return the index if the target is found. 
        // If not, return the index where it would be if it were inserted in order.
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target || nums[i] == target) return i;
            }

            return nums.Length;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
        //    Console.ReadLine();
        //}
    }
}
