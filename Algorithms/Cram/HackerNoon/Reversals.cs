using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.HackerNoon
{
    class Reversals
    {
        static void Solve(int[] input)
        {
            int length = input.Length;
            int index = input.Length - 1;

            for (int i = 0; i < length; i++)
            {
                var temp = input[i];
                input[i] = input[index - i];
                input[index - i] = temp;
            }
        }

        static void Solve2(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = input.Length - 1; i <= 0; i--)
            {
                sb.Append(input[i]);
            }

            Console.WriteLine(sb);
        }

    }
}
