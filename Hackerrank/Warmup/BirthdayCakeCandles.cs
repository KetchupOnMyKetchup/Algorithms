using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    public class BirthdayCakeCandles
    {
        static int birthdayCakeCandles_problem(int[] ar)
        {
            // find highest number
            int maxHeight = ar.Max();

            // find how many 
            int count = 0;

            foreach (int candleHeight in ar)
            {
                if (maxHeight == candleHeight) count++;
            }

            return count;
        }

        // Insert into console
        // 4
        // 3 1 2 3

        //static void Main(string[] args)
        //{
        //    int arCount = Convert.ToInt32(Console.ReadLine());

        //    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        //    int result = birthdayCakeCandles(ar);
        //}
    }
}
