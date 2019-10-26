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
            //str = str.Replace(" ", string.Empty); Too slow, iterates through whole thing + extra storage for new string

            int result = 0;
            bool isNegative = false;

            int i = 0;
            while (i < str.Length && str[i] == ' ') i++;

            if (str[i] == '-')
            {
                isNegative = true;
                i++;
            }
            else if (str[i] == '+') i++;

            for (; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i])) break;
                else
                {
                    int num = str[i] - '0';

                    if (result > int.MaxValue / 10 || result == int.MaxValue / 10 && str[i] - '0' > 7)
                        return isNegative ? int.MinValue : int.MaxValue;

                    result = (result * 10) + num;
                }
            }

            if (isNegative) result *= -1;

            return result;
        }

        //public static void Main()
        //{
        //    Console.WriteLine(MyAtoi("   "));
        //    Console.ReadLine();
        //}
    }
}
