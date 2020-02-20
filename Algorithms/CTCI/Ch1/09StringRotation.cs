using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    class _09StringRotation
    {
        private static bool IsSubstring(string s1, string s2)
        {
            if (s1.Length == s2.Length && s1.Length != 0)
            {
                StringBuilder sb = new StringBuilder(s1);
                var s1s1 = sb.Append(s1).ToString();
                return s1s1.Contains(s2);
            }

            return false;
        }

        //public static void Main()
        //{
        //    string s1 = "waterbottle";
        //    string s2 = "terbottlewa";

        //    var result = IsSubstring(s1, s2);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
    }
}
