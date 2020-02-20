using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _15ThreeSumZero
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> finalList = new List<IList<int>>();
            if (nums.Length == 0) return finalList;

            // Can implement insertion sort later
            Array.Sort(nums);

            for (int i = 0; i + 2 < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) // skip same result
                {
                    continue;
                }

                int j = i + 1;
                int k = nums.Length - 1; // last array indices
                int target = -nums[i];

                while (j < k) //make sure j and k don't cross
                {
                    if (nums[j] + nums[k] == target)
                    {
            
                        finalList.Add(new List<int>() { nums[i], nums[j], nums[k] });

                        j++;
                        k--;

                        while (j < k && nums[j] == nums[j - 1]) j++; // ?
                        while (j < k && nums[k] == nums[k + 1]) k--; // ?
                    }
                    else if (nums[j] + nums[k] > target)
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
                return finalList;
        }

        //public static void Main()
        //{
        //    int[] myArr = new int[] { -1, 0, 1, 2, -1, -4 };
        //    //int[] myArr = new int[] { -2, 0, 0, 2, 2 };

        //    foreach (var result in ThreeSum(myArr))
        //    {
        //        Console.WriteLine(result);
        //    }

        //    Console.ReadLine();
        //}
    }
}
