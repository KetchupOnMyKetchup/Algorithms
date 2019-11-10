using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _006ZigZagConversion
    {
        //public static void Main()
        //{
        //    string result = Convert("PAYPALISHIRING", 3);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        private static string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;

            List<StringBuilder> sbList = new List<StringBuilder>();

            for (int i = 0; i < Math.Min(numRows, s.Length); i++)
            {
                sbList.Add(new StringBuilder());
            }

            // add to lists. count up to max, then back down
            bool isGoingUp = false;
            int j = 0;

            foreach (var item in s.ToCharArray())
            {
                // add to existing list
                sbList[j].Append(item);

                // determine next list that will be used
                if (j == 0 || j == numRows - 1) isGoingUp = !isGoingUp;
                j += isGoingUp ? 1 : -1;
            }

            // smash n lists together and convert to string
            StringBuilder finalString = new StringBuilder();
            foreach (var item in sbList) finalString.Append(item);

            return finalString.ToString();
        }
    }
}
