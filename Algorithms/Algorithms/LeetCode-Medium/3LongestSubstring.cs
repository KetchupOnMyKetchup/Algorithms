using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class LongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> hashSet = new HashSet<char>();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    bool wasAdded = hashSet.Add(s[j]);
                    if (!wasAdded)
                    {
                        if (hashSet.Count > count) count = hashSet.Count;
                        hashSet.Clear();
                        break;
                    }
                }
            }

            if (hashSet.Count > count) count = hashSet.Count;

            return count;
        }

        //static void Main()
        //{
        //    LengthOfLongestSubstring("pwwkew");
        //}
    }
}
