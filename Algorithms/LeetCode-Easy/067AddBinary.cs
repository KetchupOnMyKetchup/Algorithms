using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _067AddBinary
    {
        //public static void Main()
        //{
        //    string a = "1010";
        //    string b = "1011";

        //    string result = AddBinary(a, b);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        private static string AddBinary(string a, string b)
        {
            int ai = a.Length - 1;
            int bi = b.Length - 1;

            StringBuilder sb = new StringBuilder();

            int carryOver = 0;

            for (int i = ai > bi ? ai : bi; i >= 0; i--)
            {
                int aValue = ai >= 0 ? a[ai--] - '0' : 0;
                int bValue = bi >= 0 ? b[bi--] - '0' : 0;

                int curr = (aValue) + (bValue) + carryOver;

                carryOver = 0;

                if (curr == 3)
                {
                    sb.Insert(0, "1");
                    carryOver = 1;
                }
                else if (curr == 2)
                {
                    sb.Insert(0, "0");
                    carryOver = 1;
                }
                else
                {
                    sb.Insert(0, curr.ToString());
                }
            }

            if (carryOver > 0) sb.Insert(0, "1");

            return sb.ToString();
        }
    }
}
