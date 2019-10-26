using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _01TwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int needed = target - nums[i];

                if (dict.ContainsKey(nums[i]))
                {
                    if (needed == nums[i])
                    {
                        return i > dict[needed] ? new int[] { dict[needed], i } : new int[] { i, dict[needed] };
                    }

                    continue;
                }

                dict.Add(nums[i], i);


                if (dict.ContainsKey(needed) && needed != nums[i])
                {
                    return i > dict[needed] ? new int[] { dict[needed], i } : new int[] { i, dict[needed] };
                }
            }

            return null;
        }

        //public static void Main()
        //{
        //    int[] myArr = new int[] { 3, 2, 4 };

        //    int[] value = TwoSum(myArr, 6);
        //    Console.WriteLine(value);

        //    Console.ReadLine();
        //}
    }
}
