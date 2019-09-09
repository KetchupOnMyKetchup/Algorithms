using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class IntToRoman
    {
        public string intToRoman(int num)
        {
            string[] M = new string[] { "", "M", "MM", "MMM" };
            string[] C = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] X = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] I = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
        }
    }
}
