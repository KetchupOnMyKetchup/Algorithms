using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.HackerrankEasy
{
    class PlusMinus
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            double count = arr.Length;
            double positive = 0;
            double negative = 0;
            double zero = 0;

            foreach (var item in arr)
            {
                if (item > 0) positive++;
                else if (item == 0) zero++;
                else negative++;
            }

            Console.WriteLine(positive / count);
            Console.WriteLine(negative / count);
            Console.WriteLine(zero / count);

        }

        //static void Main(string[] args)
        //{
        //    int n = 6;

        //    int[] arr = new int[] { -4, 3,-9, 0, 4, 1  };

        //    plusMinus(arr);
        //}
    }
}
