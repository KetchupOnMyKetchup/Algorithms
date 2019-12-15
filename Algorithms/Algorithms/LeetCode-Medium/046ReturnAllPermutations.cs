using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _046ReturnAllPermutations
    {
        //public static void Main()
        //{
        //    int[] nums = { 2, 2, 1 };

        //    var results = Permute(nums);

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

        //public int[] TwoSum(int[] nums, int target)
        //{
        //    int i1 = 0;
        //    int i2 = 1;


        //    for (i1 = 0; i1 < target - 1; i1++)
        //    {
        //        for (i2 < target; i2++)
        //        {
        //            if (i1 + i2 == target) return new int[] { i1, i2 };
        //        }
        //    }

        //    return new int[] { i1, i2 };
        //}

        //public static IList<IList<int>> Permute(int[] nums)
        //{
        //    List<IList<int>> list = new List<IList<int>>();
        //    //Array.Sort(nums);
        //    BackTrack(list, new List<int>(), nums);
        //    return list;
        //}

        //private static void BackTrack(List<IList<int>> list, List<int> tempList, int[] nums)
        //{
        //    if (tempList.Count == nums.Length)
        //    {
        //        list.Add(new List<int>(tempList));
        //    }
        //    else
        //    {
        //        for (int i = 0; i < nums.Length; i++)
        //        {
        //            if (tempList.Contains(nums[i])) continue; // element already exists, skip
        //            tempList.Add(nums[i]);
        //            BackTrack(list, tempList, nums);
        //            tempList.RemoveAt(tempList.Count - 1);
        //        }
        //    }
        //}
    }
}
