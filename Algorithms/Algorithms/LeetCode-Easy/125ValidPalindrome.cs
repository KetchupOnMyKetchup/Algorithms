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
            char[] arr = s.ToCharArray();

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                if (!char.IsLetterOrDigit(arr[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(arr[right]))
                {
                    right--;
                }
                else
                {
                    if (char.ToLower(arr[left]) != char.ToLower(arr[right])) return false;
                    left++;
                    right--;
                }
            }

            return true;
        }

        //public static bool IsPalindrome2(string s)
        //{
        //    char[] c = s.ToCharArray();

        //    for (int head = 0, tail = c.Length - 1; head < tail;)
        //    {
        //        if (!char.IsLetterOrDigit(s[head])) head++;
        //        else if (!char.IsLetterOrDigit(s[tail])) tail--;
        //        else
        //        {
        //            if (char.ToLower(s[head]) != char.ToLower(s[tail])) return false;
        //            head++;
        //            tail--;
        //        }
        //    }

        //    return true;
        //}
    }
}
