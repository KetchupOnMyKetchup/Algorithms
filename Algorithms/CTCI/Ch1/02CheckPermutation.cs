using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    class _02CheckPermutation
    {
        public static bool CheckPermutation(string input, string input2)
        {
            if (input.Length != input2.Length) return false;

            int[] letters = new int[128]; // Assumption ASCII only

            for (int i = 0; i < input.Length; i++)
            {
                letters[input[i]]++;
            }

            for (int i = 0; i < input2.Length; i++)
            {
                int c = input2[i];
                letters[c]--;

                if (letters[c] < 0) return false;
            }

            return true;
        }

        //public static void Main()
        //{
        //    string input = "cats";
        //    string input2 = "sact";
        //    Console.WriteLine(CheckPermutation(input, input2));
        //    Console.ReadLine();
        //}
    }
}
