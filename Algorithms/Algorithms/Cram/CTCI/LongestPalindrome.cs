using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.Cram.CTCI
{
    class LongestPalindrome
    {
        static string longestPalindrome = "";
        static int lengthLongestPalindrome = 0;

        static void Solve(string input)
        {
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                // TACOCAT

                for (int j = 0; j < length; j++)
                {
                    if (i - j > 0)
                    {
                        //CheckIfPalindrome(input.Substring(j-1,));
                    }

                    if (j + 1 < length)
                    {
                        CheckIfPalindrome(input);
                    }

                    if (j - 1 < 0 && j + 1 > length)
                    {
                        CheckIfPalindrome(input);
                    }

                }
            }
        }

        private static void CheckIfPalindrome(string input)
        {
    
            if (input == input.Reverse() && input.Length > lengthLongestPalindrome)
            {
                longestPalindrome = input;
                lengthLongestPalindrome = input.Length;
            }
        }

        public class Solution
        {
        }
    }
}
