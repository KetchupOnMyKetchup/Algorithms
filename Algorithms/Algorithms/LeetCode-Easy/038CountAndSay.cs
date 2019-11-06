using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _038CountAndSay
    {
        private static string CountAndSay(int n)
        {
            StringBuilder curr = new StringBuilder("1");
            StringBuilder prev;
            int count;
            char say;

            for (int i = 1; i < n; i++)
            {
                prev = curr;
                curr = new StringBuilder();
                count = 1;
                say = prev[0];

                for (int j = 1, len = prev.Length; j < len; j++)
                {
                    if (prev[j] != say)
                    {
                        curr.Append(count).Append(say);
                        count = 1;
                        say = prev[j];
                    }
                    else count++;
                }
                curr.Append(count).Append(say);
            }

            return curr.ToString();
        }

        //public static void Main()
        //{
        //    int n = 5;
        //    var result = CountAndSay(n);

        //    Console.WriteLine(result);

        //    Console.ReadLine();
        //}
    }
}
