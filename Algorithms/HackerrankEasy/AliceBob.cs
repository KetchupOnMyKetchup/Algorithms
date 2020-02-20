using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.HackerrankEasy
{
    class AliceBob
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> aliceBob = new List<int>() { 0, 0 };

            int length = a.Count;

            for (int i = 0; i < length; i++)
            {
                if (a[i] > b[i]) aliceBob[0]++;
                else if (a[i] < b[i]) aliceBob[1]++;
            }

            return aliceBob;
        }

        //static void Main(string[] args)
        //{
        //    List<int> a = new List<int>() { 1, 2, 3 };
        //    List<int> b = new List<int>() { 3, 2, 1 };

        //    List<int> result = compareTriplets(a, b);
        //}
    }
}
