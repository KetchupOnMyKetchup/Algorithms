using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Hard
{
    class _041FirstMissingPositive
    {
        //public static void Main()
        //{
        //    int[] nums = new int[] { 1 };
        //    int result = FirstMissingPositive(nums);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        // https://leetcode.com/problems/first-missing-positive/discuss/17083/O(1)-space-Java-Solution
        private static int FirstMissingPositive(int[] nums)
        {
            int i = 0;

            while (i < nums.Length)
            {
                // go over ** nums[nums[i] - 1] != nums[i] < -- this
                if (nums[i] >= 1 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
                {
                    swap(nums, i, nums[i] - 1);
                }
                else i++;
            }

            i = 0;

            while (i < nums.Length && nums[i] == i + 1) i++;
            return i + 1;
        }

        private static void swap(int[] nums, int i, int v)
        {
            int temp = nums[i];
            nums[i] = nums[v];
            nums[v] = temp;
        }

        // Not constant extra space
        //private static int FirstMissingPositive(int[] nums)
        //{
        //    // add all to hashset
        //    HashSet<int> hs = new HashSet<int>();

        //    foreach (var item in nums) hs.Add(item);

        //    // check if has it from 1
        //    for (int i = 1; i <= nums.Length + 1; i++)
        //    {
        //        if (hs.Add(i)) return i;
        //    }

        //    return 1;
        //}
    }
}
