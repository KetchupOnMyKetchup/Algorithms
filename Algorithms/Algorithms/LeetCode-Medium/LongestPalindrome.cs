using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class LongestPalindromeLeetCode
    {
        static int lo = 0;
        static int maxLen = 0;

        public static string LongestPalindrome(string s)
        {
            int len = s.Length;
            if (len < 2)
                return s;

            for (int i = 0; i < len - 1; i++)
            {
                extendPalindrome(s, i, i);  //assume odd length, start with 2 letter, try to extend Palindrome as possible
                extendPalindrome(s, i, i + 1); //assume even length, start with 2 letters.
            }
            return s.Substring(lo, maxLen);
        }

        private static void extendPalindrome(string s, int j, int k)
        {
            // Check to see if Palindrome
            while (j >= 0 && k < s.Length && s[j] == s[k])
            {
                j--;
                k++;
            }
            if (maxLen < k - j - 1)
            {
                lo = j + 1;
                maxLen = k - j - 1;
            }
        }

        //public static void Main()
        //{
        //    Console.WriteLine(LongestPalindrome("tacocat"));
        //    Console.ReadLine();
        //}
    }
}
