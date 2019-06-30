using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class LongestCommonPrefixClass
    {

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            // grab first word
            string prefix = strs[0];

            // keep only prefix letters that are in common with next word
            foreach (var item in strs)
            {
                // check to see if prefix is in next word
                if (prefix.Length > item.Length || prefix != item.Substring(0, prefix.Length))
                {
                    prefix = FindNewPrefix(prefix, item);
                }

                if (prefix.Length == 0) return "";
            }

            return prefix;
        }

        private static string FindNewPrefix(string prefix, string item)
        {
            int length = prefix.Length;
            if (prefix.Length > item.Length) length = item.Length;

            StringBuilder newPrefix = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                if (prefix[i] == item[i]) newPrefix.Append(item[i]);
                else break;
            }

            return newPrefix.ToString();
        }

        //static void Main(string[] args)
        //{
        //    string[] strings = new string[] { "flora", "flea", "florida" };

        //    Console.WriteLine(LongestCommonPrefix(strings));
        //    Console.ReadLine();
        //}
    }
}
