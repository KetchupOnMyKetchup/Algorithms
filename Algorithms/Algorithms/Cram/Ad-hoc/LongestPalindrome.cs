using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.Cram.Ad_hoc
{
    class LongestPalindrome
    {
        static string LargestPalindrome(string input)
        {
            int longest = 0;
            int limit = input.Length;
            for (int i = 0; i < limit; i++)
            {
                for (int j = limit - 1; j > i; j--)
                {
                    string forStr = input.Substring(i, j - i);
                    string revStr = new string(forStr.Reverse().ToArray());
                    if (forStr == revStr && forStr.Length > longest)
                    {
                        return forStr;
                    }
                }
            }
            return "";
        }
    }
}
