using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/diagonal-difference/problem
    public class Staircase
    {
        static void Staircase_Problem(int n, int i = 1)
        {
            Console.WriteLine(new String('#', i).PadLeft(n));

            if (++i <= n) Staircase_Problem(n, i);
        }

        // for main
        //int n = Convert.ToInt32(Console.ReadLine());
        //staircase(n);

        //Console.ReadLine();
    }
}
