using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _090SubsetsII
    {
        //public static void Main()
        //{
        //    int[] nums = { 2, 2, 1 };

        //    var results = SubsetsII(nums);

        //    foreach (var items in results)
        //    {
        //        Console.WriteLine("break");

        //        foreach (var item in items)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }

        //    Console.ReadLine();
        //}

        public static IList<IList<int>> SubsetsII(int[] nums)
        {
            List<IList<int>> list = new List<IList<int>>();
            Array.Sort(nums);
            BackTrack(list, new List<int>(), nums, 0);
            return list;
        }

        private static void BackTrack(List<IList<int>> list, List<int> tempList, int[] nums, int start)
        {
            list.Add(new List<int>(tempList));

            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1]) 
                    continue;

                tempList.Add(nums[i]);
                BackTrack(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
