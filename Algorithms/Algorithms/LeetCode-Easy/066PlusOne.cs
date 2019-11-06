using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _066PlusOne
    {
        //public static void Main()
        //{
        //    int[] n = new int[] { 9, 9, 9 };
        //    int[] result = PlusOne(n);

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();
        //}

        private static int[] PlusOne(int[] digits)
        {
            for (int j = digits.Length - 1; j >= 0; j--)
            {
                digits[j] = digits[j] + 1;

                if (digits[j] >= 10) digits[j] = digits[j] - 10;
                else return digits;
            }

            if (digits[0] == 0)
            {
                digits = new int[digits.Length + 1];
                digits[0] = 1;
            }

            return digits;
        }

        //private static int[] DealWithNines(int[] n, int i, int fullLength)
        //{
        //    if (i >= 0 && n[i] == 9)
        //    {
        //        n[i] = 0;

        //        if (i >= 1 && n[i - 1] != 9)
        //        {
        //            n[i - 1] = n[i - 1] + 1;
        //        }
        //        else if (i == 0)
        //        {
        //            n = new int[fullLength + 1];
        //            n[0] = 1;
        //        }
        //        else // if [n-1] == 9
        //        {
        //            DealWithNines(n, i - 1, fullLength);
        //        }
        //    }

        //    return n;
        //}
    }
}
