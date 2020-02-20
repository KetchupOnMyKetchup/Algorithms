using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _088MergeSortedArray
    {
        //public static void Main()
        //{
        //    int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        //    int m = 3;
        //    int[] nums2 = new int[] { 2, 5, 6 };
        //    int n = 3;
            
        //    Merge(nums1, m, nums2, n);

        //    Console.WriteLine();
        //    Console.ReadLine();
        //}

        private static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i1 = nums1.Length - 1;
            m -= 1;
            n -= 1;

            while (m >= 0 && n >= 0)
            {
                nums1[i1--] = nums1[m] > nums2[n] ? nums1[m--] : nums2[n--];
            }
            while (n >= 0)
            {
                nums1[i1--] = nums2[n--];
            }

            //for (int i = nums1.Length - 1; i >= 0; i--)
            //{
            //    if ((n < 0 || nums1[m] > nums2[n]))
            //    {
            //        nums1[i] = nums1[m];
            //        m--;
            //    }
            //    else
            //    {
            //        nums1[i] = nums2[n];
            //        n--;
            //    }
            //}
        }
    }
}

