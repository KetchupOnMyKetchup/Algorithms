using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Hard
{
    class _004Median2SortedArrays
    {
        //public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        //{
        //    int length = nums1.Length + nums2.Length;

        //    int p1 = 0;
        //    int p2 = 0;

        //    bool isFirstArray = false;

        //    for (int i = 0; i < (length + 1) / 2; i++)
        //    {
        //        isFirstArray = FindLowest(nums1, nums2, ref p1, ref p2);
        //    }

        //    var result = isFirstArray ? nums1[p1 - 1] : nums2[p2 - 1];

        //    if (length % 2 != 0) return result;
        //    return (result + (FindLowest(nums1, nums2, ref p1, ref p2) ? nums1[p1 - 1] : nums2[p2 - 1])) / 2.0;
        //}

        //private static bool FindLowest(int[] nums1, int[] nums2, ref int p1, ref int p2)
        //{
        //    bool isFirstArray;
        //    if (p1 == nums1.Length || (p2 < nums2.Length && nums1[p1] > nums2[p2]))
        //    {
        //        p2++;
        //        isFirstArray = false;
        //    }
        //    else
        //    {
        //        p1++;
        //        isFirstArray = true;
        //    }

        //    return isFirstArray;
        //}

     
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i = 0;
            int j = 0;

            int total = nums1.Length + nums2.Length;
            bool isEven = total % 2 == 0;

            int mid = total / 2;

            int curr = 0;
            int prev = 0;

            while (i + j <= mid)
            {
                prev = curr;

                if (i < nums1.Length && (j >= nums2.Length || nums1[i] > nums2[j])) curr = nums1[i++];
                else curr = nums2[j++];
            }

            return isEven ? (prev + curr) / 2.0 : curr;
        }

        //public static void Main()
        //{
        //    int[] nums1 = new int[] { 1, 2 };
        //    int[] nums2 = new int[] { 3, 4 };

        //    Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        //    Console.ReadLine();
        //}
    }
}
