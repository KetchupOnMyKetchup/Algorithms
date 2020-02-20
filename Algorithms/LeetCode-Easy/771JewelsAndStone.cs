using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _771JewelsAndStone
    {
        public static int NumJewelsInStones(string J, string S)
        {
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < J.Length; i++) dict.Add(J[i], 0);

            for (int i = 0; i < S.Length; i++)
            {
                if (dict.ContainsKey(S[i])) dict[S[i]]++;
            }

            return dict.Sum(x => x.Value);

            // BAD, double for loop
            //for (int i = 0; i < S.Length; i++)
            //{
            //    if (J.Contains(S[i]))
            //    {
            //        count++;
            //    }
            //}
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(NumJewelsInStones("aA", "aAAbbbb").ToString());
        //    Console.ReadLine();
        //}
    }
}
