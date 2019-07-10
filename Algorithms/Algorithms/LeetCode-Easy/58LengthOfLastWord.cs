using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class LengthOfLastWord
    {
        public static int LengthOfLastWord1(string s)
        {
            int lng = s.Length;
            int counter = 0;
            int _temp = 0;
            for (int i = 0; i < lng; i++)
            {
                if (s[i] != ' ') _temp = ++counter;
                else counter = 0;
            }
            return counter > _temp ? counter : _temp;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(LengthOfLastWord1("I cat    "));
        //    Console.ReadLine();
        //}
    }
}
