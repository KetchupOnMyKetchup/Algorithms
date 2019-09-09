using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.HackerrankEasy
{
    class Kangaroo
    {
        static string kangarooo(int x1, int v1, int x2, int v2)
        {
            if (x1 > x2 && v1 > v2) return "NO";
            if (x1 < x2 && v1 < v2) return "NO";
            if (x1 == x2) return "YES";

            bool X1Bigger = false;

            if (x1 > x2)
            {
                X1Bigger = true;
            }

            while (x1 <= int.MaxValue)
            {
                x1 += v1;
                x2 += v2;

                if (x1 == x2) return "YES";
                if (X1Bigger && x2 > x1) break;
                if (!X1Bigger && x2 < x1) break;
            }

            return "NO";
        }

        //static void Main(string[] args)
        //{
        //    kangarooo(21, 6, 47, 3);
        //}
    }
}
