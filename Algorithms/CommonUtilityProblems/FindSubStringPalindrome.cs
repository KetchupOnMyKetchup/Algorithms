using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CommonUtilityProblems
{
    public class FindSubStringPalindrome
    {
        public string longestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return null;

            if (s.Length == 1) return s;

            (int, int) longest = (0, 1);

            for (int i = 0; i < s.Length; i++)
            {
                // get longest palindrome with center of i
                var tmp = Helper(ref s, i, i);

                if (Length(tmp) > Length(longest))
                {
                    longest = tmp;
                }

                // get longest palindrome with center of i, i+1
                tmp = Helper(ref s, i, i + 1);
                if (Length(tmp) > Length(longest))
                {
                    longest = tmp;
                }
            }

            return s.Substring(longest.Item1, longest.Item2);
        }

        // Given a center, either one letter or two letter, 
        // Find longest palindrome
        public (int, int) Helper(ref string s, int begin, int end)
        {
            while (begin >= 0 && end <= s.Length - 1 && s[begin] == s[end])
            {
                begin--;
                end++;
            }
            return (begin + 1, end);
        }

        // Given a center, either one letter or two letter, 
        // Find longest palindrome
        public int Length((int, int) bounds)
        {
            return bounds.Item2 - bounds.Item1;
        }
    }
}
