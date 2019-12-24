using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _093RestoreIPAddresses
    {
        public static void Main()
        {
            //string s = "0000";
            string s = "010010";
            // 0.0.0.0 is valid
            // 255.255.255.255 is valid

            // 255.023.255.255 is NOT valid
            // 255.23.255.255 is valid

            var result = RestoreIpAddresses(s);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static IList<string> RestoreIpAddresses(string s)
        {
            List<string> finalResult = new List<string>();

            string[] segments = new string[4];
            SplitIp(finalResult, segments, s, 0, 0);

            return finalResult;
        }

        private static void SplitIp(List<string> finalResult, string[] segments, string s, int pointer, int segmentNum)
        {
            if (segmentNum == 4)
            {
                if (pointer == s.Length) finalResult.Add(segments[0] + "." + segments[1] + "." + segments[2] + "." + segments[3]);
                return;
            }

            for (int i = 1; i <= 3; i++)
            {
                if (pointer + i > s.Length) return;

                string temp = s.Substring(pointer, i);
                if (temp[0] == '0' && temp.Length > 1) continue;

                int.TryParse(temp.ToString(), out int res);

                if (res <= 255)
                {
                    segments[segmentNum] = temp;
                    SplitIp(finalResult, segments, s, pointer + temp.Length, segmentNum + 1);
                }

            }
        }
    }
}
