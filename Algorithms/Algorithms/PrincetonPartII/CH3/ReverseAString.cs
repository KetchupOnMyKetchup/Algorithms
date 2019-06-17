using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH3
{
    class ReverseAString
    {
        //In C#, lower-case type names are aliases for the System.xxx type names, 
        // e.g. string equals System.String and int equals System.Int32.

        // Quadtratic Time
        //public static String reverse(string s)
        //{
        //    String rev = "";
        //    for (int i = s.length() - 1; i >= 0; i--)
        //        rev += s.charAt(i);
        //    return rev;
        //}

        // Linear time
        public static String Reverse(string s)
        {
            StringBuilder rev = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
                rev.Append(s[i]);
            return rev.ToString();
        }
    }
}
