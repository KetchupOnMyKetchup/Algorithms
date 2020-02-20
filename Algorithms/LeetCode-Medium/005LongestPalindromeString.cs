using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _005LongestPalindromeString
    {
        //public static void Main()
        //{
        //    var result = LongestPalindrome("asaaztacocatt");

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        static int lo, maxLen;

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            if (s.Length < 2) return s;

            for (int i = 0; i < s.Length - 1; i++)
            {
                ExpandAroundCenter(s, i, i); // odd
                ExpandAroundCenter(s, i, i + 1); // even
            }

            return s.Substring(lo, maxLen - 1); // -1 to makeup for length of starting char
        }

        private static void ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            if (maxLen < right - left)
            {
                lo = left + 1; // add 1 back from last iteration on line 37
                maxLen = right - left;
            }
        }
    }
}
