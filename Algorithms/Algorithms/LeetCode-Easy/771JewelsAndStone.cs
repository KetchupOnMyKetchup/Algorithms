using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _771JewelsAndStone
    {
        public static int NumJewelsInStones(string J, string S)
        {
            int count = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (J.Contains(S[i]))
                {
                    count++;
                }
            }

            return count;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(NumJewelsInStones("aA", "aAAbbbb").ToString());
        //    Console.ReadLine();
        //}
    }
}
