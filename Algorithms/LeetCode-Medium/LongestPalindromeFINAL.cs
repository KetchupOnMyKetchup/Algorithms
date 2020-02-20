using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class LongestPalindromeLeetCode2
    {
        static int maxLen, finalIndexLeft = 0;

        public static string LongestPalindrome(string s)
        {
            int length = s.Length;
            if (length < 2) return s;

            for (int i = 0; i < length-1; i++)
            {
                // odd scenario
                extendFromCenter(s, i, i);

                // even scenario
                extendFromCenter(s, i, i + 1);
            }

            return s.Substring(finalIndexLeft, maxLen);
        }

        private static void extendFromCenter(string s, int indexLeft, int indexRight)
        {
            while (indexLeft >= 0 && indexRight < s.Length && s[indexLeft] == s[indexRight])
            {
                if (indexRight - indexLeft + 1 > maxLen)
                {
                    maxLen = indexRight - indexLeft + 1;
                    finalIndexLeft = indexLeft;
                }

                indexLeft--;
                indexRight++;
            }
        }

        //public static void Main()
        //{
        //    //Console.WriteLine(LongestPalindrome("abobz"));
        //    Console.WriteLine(LongestPalindrome("mjiahfiutacocatsbvhjwbfe"));
        //    Console.ReadLine();
        //}
    }
}
