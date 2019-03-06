using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank.Easy
{
    class squareroot
    {
        public static int squares(int a, int b)
        {
            int lower = (int)Math.Ceiling(Math.Sqrt(a));
            int upper = (int)Math.Floor(Math.Sqrt(b));

            if (lower >= upper) return 0;

            var result = upper - lower + 1;

            return result;
        }
        //static void Main(string[] args)
        //{
        //    int q = Convert.ToInt32(Console.ReadLine());

        //    for (int qItr = 0; qItr < q; qItr++)
        //    {
        //        string[] ab = Console.ReadLine().Split(' ');

        //        int a = Convert.ToInt32(ab[0]);

        //        int b = Convert.ToInt32(ab[1]);

        //        int result = squares(a, b);
        //    }
        //}
    }
}
