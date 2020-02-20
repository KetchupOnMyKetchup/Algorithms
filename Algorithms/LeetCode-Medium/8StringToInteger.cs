using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _8StringToInteger
    {
        public static int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return 0;

            int multiplyFactor = 1;
            int i = 0;
            int final = 0;

            // Remove whitespace
            while (i < str.Length && str[i] == ' ') i++;

            // Handle signs
            if (str[i] == '-' || str[i] == '+')
            {
                multiplyFactor = str[i] == '+' ? 1 : -1;
                i++;
            }

            // Convert num and handle overflow
            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                if (final > int.MaxValue / 10 || final == int.MaxValue / 10 && str[i] - '0' > 7)
                    return multiplyFactor == -1 ? int.MinValue : int.MaxValue;

                final = (final * 10) + (str[i++] - '0');
            }

            return final * multiplyFactor;
        }

        //public static void Main()
        //{
        //    Console.WriteLine(MyAtoi("+"));
        //    Console.ReadLine();
        //}
    }
}
