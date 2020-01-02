using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _091DecodeWays
    {
        public static void Main()
        {
            int result = NumDecodings("12");

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int NumDecodings(string s)
        {
            StringBuilder sb = new StringBuilder();

            BackTrack(new List<string>(), s, 0, sb);

            return 0;
        }

        private static void BackTrack(List<string> list, string s, int index, StringBuilder sb)
        {



            for (int i = index; i < 2; i++)
            {
                if (int.Parse(sb.Append(s[i]).ToString()) > 26)
                {
                    sb.Remove(sb.Length - 1, 1);
                    return;
                }

                BackTrack(list, s, index + i, sb);
            }
        }
    }
}
