using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank.Easy
{
    class BookProblem
    {
        // https://www.hackerrank.com/challenges/drawing-book/problem
        static int pageCount(int totalPages, int pageToTurnTo)
        {
            int front = pageToTurnTo / 2;
            int back = (totalPages / 2 - pageToTurnTo / 2);

            if (front < back) return front;
            else return back;
        }

        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int p = Convert.ToInt32(Console.ReadLine());

        //    int result = pageCount(n, p);
        //}
    }
}
