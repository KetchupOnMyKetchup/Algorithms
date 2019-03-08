using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank.Easy
{
    class UtopianTree
    {
        // https://www.hackerrank.com/challenges/utopian-tree/problem
        static int utopianTree(int n)
        {
            if (n == 0) return 1;

            int prevTreeHeight = 1;
            int height = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) height = prevTreeHeight * 2;
                else height = prevTreeHeight + 1;
                prevTreeHeight = height;
            }

            return height;
        }

        //static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());

        //    for (int tItr = 0; tItr < t; tItr++)
        //    {
        //        int n = Convert.ToInt32(Console.ReadLine());

        //        int result = utopianTree(n);
        //    }
        //}
    }
}
