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
            int index = N - 1;

            for (int i = 0; i < N / 2; i++)
            {
                double temp = a[i];
                a[i] = a[index - i];
                a[index - i] = temp;
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
