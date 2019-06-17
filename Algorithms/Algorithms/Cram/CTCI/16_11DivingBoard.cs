using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.CTCI
{
    /// <summary>
    /// You are building a diving board by placing a bunch of planks of wood end-to-end.
    /// There are two types of planks, one of length shorter and one of length longer.You must use
    /// exactly K planks of wood. Write a method to generate all possible lengths for the diving board.
    /// </summary>
    class _16_11DivingBoard
    {

        static void DivingBoardSize(int plankA, int plankB, int kNumberOfPlanks)
        {
            int length = 0;

            List<int> allLengths = new List<int>();

            // if plankA and B are same size, then just return the one possible option

            for (int i = 0; i < kNumberOfPlanks; i++)
            {
                length = (i) * plankA + (kNumberOfPlanks - i) * plankB;

                allLengths.Add(length); // could be dupes, could use HashSet to prevent this
            }
        }

        //static void Main(string[] arg)
        //{
        //    DivingBoardSize(10, 4, 6);
        //}
    }
}
