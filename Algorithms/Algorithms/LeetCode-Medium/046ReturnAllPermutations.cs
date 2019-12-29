using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _046ReturnAllPermutations
    {
        public static void Main()
        {
            int[] nums = { 1, 2, 3 };

            var results = Permute(nums);

            foreach (var items in results)
            {
                Console.WriteLine("break");

                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }

      
        public static IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> list = new List<IList<int>>();

            BackTrack(list, new List<int>(), nums);

            return list;
        }

        private static void BackTrack(List<IList<int>> list, List<int> partialList, int[] nums)
        {
            if (nums.Length == partialList.Count)
            {
                list.Add(new List<int>(partialList));
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (partialList.Contains(nums[i])) continue;
                partialList.Add(nums[i]);

                BackTrack(list, partialList, nums);
                partialList.RemoveAt(partialList.Count - 1);
            }

        }
    }
}
