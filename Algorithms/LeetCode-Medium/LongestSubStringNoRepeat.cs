using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    /// <summary>
    /// To decrease memory usage: 
    /// Could also have done an array of booleans, 0-25 with true/false for each letter
    /// Assuming only lower case is used
    /// End at 26 if needed, since 26 is the longest it could be
    /// </summary>
    class LongestSubStringNoRepeat
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int finalCount = 0;
            if (string.IsNullOrEmpty(s)) return 0;

            int leftPointer = 0, rightPointer = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            while (rightPointer < s.Length)
            {
                var isFound = dict.TryGetValue(s[rightPointer], out int index);
                dict[s[rightPointer]] = rightPointer;

                rightPointer++;

                if (isFound && leftPointer <= index) leftPointer = index + 1; // cannot go backwards

                finalCount = Math.Max(finalCount, rightPointer - leftPointer);
            }

            //while (rightPointer < s.Length)
            //{
            //    var isFound = dict.TryGetValue(s[rightPointer], out int index);

            //    if (!isFound || index < leftPointer)
            //    {
            //        //dict.Add(s[rightPointer], rightPointer);
            //        dict[s[rightPointer]] = rightPointer;
            //        rightPointer++;

            //        count = rightPointer - leftPointer;
            //        if (count > finalCount) finalCount = count;
            //    }
            //    else
            //    {
            //        leftPointer = index + 1;
            //        dict[s[rightPointer]] = rightPointer;
            //        rightPointer++;

            //        continue;
            //    }
            //}

            return finalCount;
        }

        //public static void Main()
        //{
        //    //Console.WriteLine(LengthOfLongestSubstring("aabcdexxxikaavca"));
        //    Console.WriteLine(LengthOfLongestSubstring("abba"));
        //    //Console.WriteLine(LengthOfLongestSubstring("jbpnbwwd"));
        //    //Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
        //    //Console.WriteLine(LengthOfLongestSubstring(" "));
        //    //Console.WriteLine(LengthOfLongestSubstring("dvdf"));
        //    Console.ReadLine();
        //}
    }
}
