using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    class _05OneAway
    {
        private static bool OneAway(string input1, string input2)
        {
            if (input1 == input2) return true;
            if (Math.Abs(input1.Length - input2.Length) > 1) return false;

            // find out which string is longer
            string s1 = input1.Length < input2.Length ? input1 : input2; // smaller
            string s2 = input1.Length < input2.Length ? input2 : input1; // larger

            int index1 = 0;
            int index2 = 0;

            bool foundDifference = false;

            while(index1 < s1.Length && index2 < s2.Length)
            {
                if (s1[index1] != s1[index2])
                {
                    if (foundDifference) return false;
                    foundDifference = true;

                    if (s1.Length == s2.Length) index1++;
                }
                else index1++; // if are equal, move shorter index

                index2++;
            }

            return false;
        }

        //public static void Main()
        //{
        //    string input1 = "pale";
        //    string input2 = "ple";
        //    Console.WriteLine(OneAway(input1, input2));
        //    Console.ReadLine();
        //}
    }
}
