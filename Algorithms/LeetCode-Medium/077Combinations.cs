using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _077Combinations
    {
        //static void Main()
        //{
        //    var results = Combine(1, 1);

        //    foreach (var result in results)
        //    {
        //        foreach (var item in result)
        //        {
        //            Console.WriteLine(item);
        //        }

        //        Console.WriteLine("-------------------------");
        //    }
        //}

        static List<IList<int>> final = new List<IList<int>>();

        public static IList<IList<int>> Combine(int n, int k)
        {
            Helper(n, k, 1, new List<int>());
            return final;
        }

        private static void Helper(int n, int k, int startIndex, List<int> list)
        {
            if (list.Count == k)
            {
                final.Add(new List<int>(list));
                return;
            }

            for (int i = startIndex; i <= n; i++)
            {
                list.Add(i);

                Helper(n, k, i + 1, list);

                list.Remove(i);
            }
        }
    }
}
