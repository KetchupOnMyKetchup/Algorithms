using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _120Triangle
    {
        //public static void Main()
        //{
        //    List<IList<int>> triangle = new List<IList<int>>();
        //    triangle.Add(new List<int>() { 2 });
        //    triangle.Add(new List<int>() { 3, 4 });
        //    triangle.Add(new List<int>() { 6, 5, 7 });
        //    triangle.Add(new List<int>() { 4, 1, 8, 3 });

        //    int result = MinimumTotal(triangle);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        // https://codinginterviewclass.com/courses/633601/lectures/11725959 3:32
        public static int MinimumTotal(IList<IList<int>> triangle)
        {
            int lastLayerIndex = triangle.Count - 1;

            IList<int> minLen = triangle[lastLayerIndex];

            for (int layer = lastLayerIndex - 1; layer >= 0; layer--) // bottom up on layers
            {
                for (int i = 0; i <= layer ; i++) // layer matches count # in row
                {
                    // can assume comparing i and i + 1 (adjacent)
                    minLen[i] = Math.Min(minLen[i], minLen[i + 1]) + triangle[layer][i]; // can access list with col/row
                }
            }

            return minLen[0];
        }
    }
}
