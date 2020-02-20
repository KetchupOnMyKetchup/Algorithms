using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class LongestCommonPrefixClass
    { 
        //static void Main(string[] args)
        //{
        //    string[] strings = new string[] { "flower", "flow", "flight" };

        //    Console.WriteLine(LongestCommonPrefix(strings));
        //    Console.ReadLine();
        //}

    public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            int minLen = int.MaxValue;
            foreach (var str in strs) minLen = Math.Min(minLen, str.Length);

            int low = 1;
            int high = minLen;

             while (low <= high)
            {
                int middle = low + (high - low) / 2;

                if (isCommonPrefix(strs, middle)) // start at middle, if it works as a prefix for all, then add 1, if not subtract 1 and try that
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }

            return strs[0].Substring(0, (low + high) / 2);

        }

        private static bool isCommonPrefix(string[] strs, int len)
        {
            string str1 = strs[0].Substring(0, len);

            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Substring(0, len) != str1) return false;
            }

            return true;
        }
        

        //public static string LongestCommonPrefix(string[] strs)
        //{
        //    if (strs.Length == 0) return "";

        //    // grab first word
        //    string prefix = strs[0];

        //    // keep only prefix letters that are in common with next word
        //    foreach (var item in strs)
        //    {
        //        // check to see if prefix is in next word
        //        if (prefix.Length > item.Length || prefix != item.Substring(0, prefix.Length))
        //        {
        //            prefix = FindNewPrefix(prefix, item);
        //        }

        //        if (prefix.Length == 0) return "";
        //    }

        //    return prefix;
        //}

        //private static string FindNewPrefix(string prefix, string item)
        //{
        //    int length = prefix.Length;
        //    if (prefix.Length > item.Length) length = item.Length;

        //    StringBuilder newPrefix = new StringBuilder();

        //    for (int i = 0; i < length; i++)
        //    {
        //        if (prefix[i] == item[i]) newPrefix.Append(item[i]);
        //        else break;
        //    }

        //    return newPrefix.ToString();
        //}
    }
}
