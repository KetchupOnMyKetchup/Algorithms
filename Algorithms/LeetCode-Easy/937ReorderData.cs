using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _937ReorderData
    {
        public static string[] ReorderLogFiles(string[] logs)
        {
            var logsDict = new Dictionary<string, int>();
            for (var i = 0; i < logs.Length; i++)
                logsDict[logs[i]] = i;

            Array.Sort(logs, new LogComparer(logsDict));
            return logs;
        }

        class LogComparer : IComparer<string>
        {
            private Dictionary<string, int> _logs;
            public LogComparer(Dictionary<string, int> logs)
            {
                _logs = logs;
            }

            public int Compare(string a, string b)
            {
                var firstSpaceA = a.IndexOf(" ");
                var firstSpaceB = b.IndexOf(" ");
                if (a[firstSpaceA + 1] < 'a' && b[firstSpaceB + 1] < 'a')
                {
                    return _logs[a] - _logs[b];
                }
                else if (a[firstSpaceA + 1] >= 'a' && b[firstSpaceB + 1] >= 'a')
                {
                    var subStrA = a.Substring(firstSpaceA + 1);
                    var prefixA = a.Substring(0, firstSpaceA);
                    var subStrB = b.Substring(firstSpaceB + 1);
                    var prefixB = b.Substring(0, firstSpaceB);
                    var r = string.Compare(subStrA, subStrB);
                    return r == 0 ? string.Compare(prefixA, prefixB) : r;
                }
                else
                {
                    return a[firstSpaceA + 1] < 'a' ? 1 : -1;
                }
            }
        }

        //static void Main(string[] args)
        //{
        //    ReorderLogFiles(new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"  });
        //    Console.ReadLine();
        //}
    }
}
