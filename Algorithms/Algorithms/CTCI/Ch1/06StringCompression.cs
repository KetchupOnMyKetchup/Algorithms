using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    class _06StringCompression
    {
        private static string StringCompression(string input1)
        {
            char current = input1[0];
            int count = 1;

            StringBuilder final = new StringBuilder();

            for (int i = 1; i < input1.Length; i++)
            {
                if (input1[i] == current)
                {
                    count++;
                    continue;
                }
                else
                {
                    final.Append(current);
                    final.Append(count);
                    count = 1;
                    current = input1[i];
                }
            }

            final.Append(current);
            final.Append(count);

            return final.ToString();
        }

        //public static void Main()
        //{
        //    string input1 = "aabcccccaaa";
        //    Console.WriteLine(StringCompression(input1));
        //    Console.ReadLine();
        //}
    }
}
