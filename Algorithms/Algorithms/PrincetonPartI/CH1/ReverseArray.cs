using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI
{
    class ReverseArray
    {
        public void ReverseArray1()
        {
            double[] a = new double[5] { 1.0, 2.0, 3.0, 4.0, 5.0 };
            int N = a.Length;
            for (int i = 0; i < N / 2; i++)
            {
                double temp = a[i];
                a[i] = a[N - 1 - i];
                a[N - i - 1] = temp;
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
