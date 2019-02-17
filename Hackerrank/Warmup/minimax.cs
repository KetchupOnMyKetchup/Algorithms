using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank.Warmup
{
    public class MiniMax
    {
        // https://www.hackerrank.com/challenges/mini-max-sum/problem
        static void miniMaxSum(int[] arr)
        {
            // sort numbers
            Array.Sort(arr);

            var longs = arr.Select(item => (long)item).ToArray();

            // add 4 lowest numbers
            long minSum = longs.Take(4).Sum();

            // add 4 highest numbers
            long maxSum = longs.Skip(1).Sum();

            // print min and max number to console
            Console.WriteLine(minSum + " " + maxSum);
        }

        //static void Main(string[] args)
        //{
        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //    miniMaxSum(arr);
        //}
    }
}
