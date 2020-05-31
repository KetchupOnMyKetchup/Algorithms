using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    // Given a set of distinct integers, nums, return all possible subsets (the power set).
    class _078Subsets
    {
        //public static void Main()
        //{
        //    int[] nums = { 3, 2, 1 };

        //    var results = Subsets(nums);

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

        public static IList<IList<int>> Subsets(int[] nums)
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
                tempList.Add(nums[i]);
                BackTrack(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }

    }
}
