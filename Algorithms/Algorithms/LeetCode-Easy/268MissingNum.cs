using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _268MissingNum
    {
        //public static void Main()
        //{
        //    int[] nums = { 3, 0, 1 };

        //    MissingNumber(nums);
        //}

        public static int MissingNumber(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();

            foreach (var item in nums)
            {
                hash.Add(item);
            }

            for (int i = 0; i < hash.Count; i++)
            {
                if (!hash.Contains(i)) return i;
            }

            return 0;
        }
    }
}
