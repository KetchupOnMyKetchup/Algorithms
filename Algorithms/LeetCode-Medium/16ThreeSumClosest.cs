using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _16ThreeSumClosest
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int currLowest = int.MaxValue;
            int finalSum = int.MaxValue;

            for (int i = 0; i + 2 < nums.Length; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                int currSum = nums[i] + nums[j] + nums[k];

                if (j < k && currSum == target)
                {
                    return currSum;
                }
                else if(j < k && currSum < target)
                {
                    int temp = Math.Min(currLowest, Math.Abs(target - (currSum)));

                    if (temp < currLowest)
                    {
                        currLowest = temp;
                        finalSum = currSum;
                    }

                    j++;
                }
                else if (j < k && currSum > target)
                {
                    int temp = Math.Min(currLowest, Math.Abs(target - (currSum)));

                    if (temp < currLowest)
                    {
                        currLowest = temp;
                        finalSum = currSum;
                    }

                    k--;
                }
                else
                {
                    continue;
                }
            }

            return finalSum;
        }

        //public static void Main()
        //{
        //    int[] myArr = new int[] { 0, 2, 1, -3 };
        //    //int[] myArr = new int[] { -2, 0, 0, 2, 2 };

        //    Console.WriteLine(ThreeSumClosest(myArr, 1));
        //    Console.ReadLine();
        //}
    }
}
