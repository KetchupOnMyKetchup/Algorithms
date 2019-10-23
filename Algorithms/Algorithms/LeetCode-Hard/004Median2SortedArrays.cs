using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Hard
{
    class _004Median2SortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int length = nums1.Length + nums2.Length;

            int p1 = 0;
            int p2 = 0;

            bool isFirstArray = false;

            for (int i = 0; i < (length + 1) / 2; i++)
            {
                isFirstArray = FindLowest(nums1, nums2, ref p1, ref p2);
            }

            var result = isFirstArray ? nums1[p1 - 1] : nums2[p2 - 1];

            if (length % 2 != 0) return result;
            return (result + (FindLowest(nums1, nums2, ref p1, ref p2) ? nums1[p1 - 1] : nums2[p2 - 1])) / 2.0;
        }

        private static bool FindLowest(int[] nums1, int[] nums2, ref int p1, ref int p2)
        {
            bool isFirstArray;
            if (p1 == nums1.Length || (p2 < nums2.Length && nums1[p1] > nums2[p2]))
            {
                p2++;
                isFirstArray = false;
            }
            else
            {
                p1++;
                isFirstArray = true;
            }

            return isFirstArray;
        }

        public static void Main()
        {
            int[] nums1 = new int[] { };
            int[] nums2 = new int[] { 3, 5 };

            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
            Console.ReadLine();
        }
    }
}
