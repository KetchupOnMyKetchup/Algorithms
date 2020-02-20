using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _009PalindromeNum
    {

        //public static void Main()
        //{
        //    bool result = IsPalindrome(1012);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        private static bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            int newv = x;
            int final = 0;

            while (newv > 0)
            {
                int remainder = newv % 10;
                newv /= 10;
                final = (final * 10) + remainder;
            }

            // see if same
            return x == final ? true : false;
        }
    }
}
