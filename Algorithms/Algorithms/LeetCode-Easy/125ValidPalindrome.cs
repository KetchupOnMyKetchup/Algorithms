using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _125ValidPalindrome
    {
        //static void Main()
        //{
        //    var result = IsPalindrome("tacocmat....");
        //    Console.WriteLine(result);
        //}

        public static bool IsPalindrome(string s)
        {
            char[] c = s.ToCharArray();

            for (int head = 0, tail = c.Length - 1; head < tail;)
            {
                if (!char.IsLetterOrDigit(s[head])) head++;
                else if (!char.IsLetterOrDigit(s[tail])) tail--;
                else
                {
                    if (char.ToLower(s[head]) != char.ToLower(s[tail])) return false;
                    head++;
                    tail--;
                }
            }

            return true;
        }
    }
}
