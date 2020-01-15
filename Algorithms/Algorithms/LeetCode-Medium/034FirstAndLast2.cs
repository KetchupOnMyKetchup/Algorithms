using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _034FirstAndLast2
    {
        public static void Main()
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            var result = SearchRange(nums, 6); // *if it doesn't work ? like with 6??

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            int[] result = { -1, -1 };

            if (nums.Length == 0) return result;

            int left = BinarySearch(nums, target, true);

            // ** SEE BELOW
            if (left == nums.Length || nums[left] != target) return result; // if it doesnt match, return {-1, -1 }

            result[0] = left;
            result[1] = BinarySearch(nums, target, false) - 1;

            return result;
        }

        private static int BinarySearch(int[] nums, int target, bool firstNum)
        {
            int l = 0;
            int r = nums.Length;
            
            while (l < r)
            {
                int mid = (l + r) / 2;

                if (nums[mid] > target || (firstNum && nums[mid] == target)) r = mid;
                else l = mid + 1;
            }

            return l;
        }
    }
}
