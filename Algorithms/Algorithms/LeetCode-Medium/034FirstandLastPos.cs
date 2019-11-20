using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _034FirstandLastPos
    {
        //public static void Main()
        //{
        //    int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
        //    int target = 8;
        //    int[] result = SearchRange(nums, target);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        private static int[] SearchRange(int[] nums, int target)
        {
            int[] targetRange = { 1, 1 };

            int leftIdx = extremeInsertionIndex(nums, target, true);

            // assert that `leftIdx` is within the array bounds and that `target`
            // is actually in `nums`.
            if (leftIdx == nums.Length || nums[leftIdx] != target) return targetRange;

            targetRange[0] = leftIdx;
            targetRange[1] = extremeInsertionIndex(nums, target, false) - 1;

            return targetRange;
        }

        private static int extremeInsertionIndex(int[] nums, int target, bool left)
        {
            int lo = 0;
            int hi = nums.Length;

            while (lo < hi)
            {
                int mid = lo + (hi - lo / 2); // same as lo + hi, but no overflow risk
                if (nums[mid] > target || (left && target == nums[mid]))
                {
                    hi = mid;
                }
                else
                {
                    lo = mid + 1;
                }
            }

            return lo;
        }
    }
}
