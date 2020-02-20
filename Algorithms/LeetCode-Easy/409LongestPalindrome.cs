using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _409LongestPalindrome
    {
        //public static void Main()
        //{
        //    string s = "abccccdd";

        //    Console.Write(LongestPalindrome(s));
        //    Console.ReadLine();
        //}

        public static int LongestPalindrome(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i])) dict[s[i]]++;
                else dict.Add(s[i], 1);
            }

            int totalSum = 0;
            bool anyOdd = false;

            foreach (var item in dict)
            {
                if (item.Value % 2 == 0) totalSum += item.Value;
                else if (item.Value >= 3)
                {
                    totalSum += item.Value - 1;
                    anyOdd = true;
                }
                else anyOdd = true;
            }

            if (anyOdd) totalSum += 1;

            return totalSum;
        }
    }
}
