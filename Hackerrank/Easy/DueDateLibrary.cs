using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank.Easy
{
    class DueDateLibrary
    {
        // https://www.hackerrank.com/challenges/library-fine/problem
        //d1, m1, y1: returned date day, month and year
        //d2, m2, y2: due date day, month and year
        static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            DateTime returnDate = new DateTime(y1, m1, d1);
            DateTime dueDate = new DateTime(y2, m2, d2);

            if (returnDate <= dueDate) return 0;
            if (returnDate.Year == dueDate.Year && returnDate.Month == dueDate.Month) return 15 * (int)(returnDate - dueDate).TotalDays;
            if (returnDate.Year == dueDate.Year) return 500 * (returnDate.Month - dueDate.Month);

            return 10000;
        }


        //static void Main(string[] args)
        //{
        //    string[] d1M1Y1 = Console.ReadLine().Split(' ');

        //    int d1 = Convert.ToInt32(d1M1Y1[0]);

        //    int m1 = Convert.ToInt32(d1M1Y1[1]);

        //    int y1 = Convert.ToInt32(d1M1Y1[2]);

        //    string[] d2M2Y2 = Console.ReadLine().Split(' ');

        //    int d2 = Convert.ToInt32(d2M2Y2[0]);

        //    int m2 = Convert.ToInt32(d2M2Y2[1]);

        //    int y2 = Convert.ToInt32(d2M2Y2[2]);

        //    int result = libraryFine(d1, m1, y1, d2, m2, y2);
        //}
    }
}
