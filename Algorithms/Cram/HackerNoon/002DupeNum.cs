using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram
{
    /// <summary>
    /// How do you find the duplicate number on a given integer array? 
    /// </summary>
    class _002DupeNum
    {
        // copy into hashset, compare, see which one is missing. N time
        // try to put into hashset and see which one gets rejected

        static void Solve(int[] array)
        {
            HashSet<int> hashSet = new HashSet<int>();

            foreach (var item in array)
            {
                bool isAdded = hashSet.Add(item);

                if (!isAdded)
                {
                    Console.WriteLine($"A duplicate is {item}");
                }
            }

        }

        //static void Main()
        //{
        //    int[] array = new int[] { 1,2,5,6,2,87,9,11,61,78,54,7,196,17, 61 };
        //    Solve(array);
        //    Console.ReadLine();
        //}
    }
}
