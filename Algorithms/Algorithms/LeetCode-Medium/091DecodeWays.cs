using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _091DecodeWays
    {
        public static void Main()
        {
            var result = NumDecodings("12");

            Console.WriteLine(result);
            Console.ReadLine();
        }

        /// <summary>
        /// Dynamic Programming method for getting count only
        /// </summary>
        //public static int NumDecodings(string s)
        //{
        //    int n = s.Length;
        //    if (n == 0) return 0;

        //    int[] memo = new int[n + 1];

        //    memo[n] = 1;
        //    memo[n - 1] = s[n - 1] != '0' ? 1 : 0;

        //    for (int i = n - 2; i >= 0; i--)
        //    {
        //        if (s[i] == '0') continue;
        //        else
        //        {
        //            if (int.Parse(s.Substring(i, 2)) <= 26)
        //            {
        //                memo[i] = memo[i + 1] + memo[i + 2];
        //            }
        //            else
        //            {
        //                memo[i] = memo[i + 1];
        //            }
        //        }
        //    }

        //    return memo[0];
        //}

        /// <summary>
        /// Recursive method for returning full list of combinations if that scenario was asked
        /// </summary>
        public static List<string> NumDecodings(string s)
        {
            List<string> list = new List<string>();

            char[] charArr = new char[27];
            charArr[0] = (char)('A' - 1);

            for (int i = 1; i < charArr.Length; i++)
            {
                charArr[i] = (char)(charArr[i - 1] + 1);
            }

            Backtrack(s, 0, new StringBuilder(), list, charArr);

            return list;
        }

        private static void Backtrack(string s, int startIndex, StringBuilder partialString, List<string> list, char[] charArr)
        {
            if (startIndex == s.Length)
            {
                string temp = partialString.Remove(partialString.Length - 1, 1).ToString();
                list.Add(temp);
                return;
            }

            for (int i = 1; i <= 2; i++)
            {
                // check if <= 26
                string temp = s.Substring(startIndex, i);
                int num = int.Parse(temp);

                if (num <= 26) partialString.Append(charArr[num] + " ");
                else i = 0;

                Backtrack(s, startIndex + i, partialString, list, charArr);

            }

        }
    }
}
