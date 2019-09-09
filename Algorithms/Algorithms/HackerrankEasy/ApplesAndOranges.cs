using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.HackerrankEasy
{
    class ApplesAndOranges
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleDistance = s - a;
            int orangeDistance = b - t;
            int numApples = 0;
            int numOranges = 0;

            // calc apples
            for (int i = 0; i < apples.Length; i++)
            {
                if (apples[i] > 0)
                {
                    int distance = apples[i] + a;
                    if (distance >= s && distance <= t) numApples++;
                }
            }

            Console.WriteLine(numApples);
            Console.ReadLine();

        }

        //static void Main(string[] args)
        //{
        //    countApplesAndOranges(7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 });
        //}
    }
}
