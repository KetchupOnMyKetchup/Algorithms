using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _005LongestPalindromeString
    {
        //public static void Main()
        //{
        //    var result = LongestPalindrome("babad");

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        static int longestCount = 0;
        static string longestPalindrome = "";

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";

            // for loop through string
            for (int i = 0; i < s.Length - 1; i++)
            {
                // call method to check if palindrome
                // start and end index
                Helper(s, i, i);
                Helper(s, i, i + 1);
            }

            return longestPalindrome;
        }

        public static void Helper(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                // check count (r - l + 1)
                int count = r - l + 1;

                // compare count to longest
                if (count > longestCount) longestPalindrome = s.Substring(l, count);

                l--;
                r++;
            }
        }

        //static int lo, maxLen;

        //public static string LongestPalindrome(string s)
        //{
        //    if (string.IsNullOrEmpty(s)) return "";
        //    if (s.Length < 2) return s;

        //    for (int i = 0; i < s.Length - 1; i++)
        //    {
        //        ExpandAroundCenter(s, i, i); // odd
        //        ExpandAroundCenter(s, i, i + 1); // even
        //    }

        //    return s.Substring(lo, maxLen - 1); // -1 to makeup for length of starting char
        //}

        //private static void ExpandAroundCenter(string s, int left, int right)
        //{
        //    while (left >= 0 && right < s.Length && s[left] == s[right])
        //    {
        //        left--;
        //        right++;
        //    }

        //    if (maxLen < right - left)
        //    {
        //        lo = left + 1; // add 1 back from last iteration on line 37
        //        maxLen = right - left;
        //    }
        //}
    }
}
