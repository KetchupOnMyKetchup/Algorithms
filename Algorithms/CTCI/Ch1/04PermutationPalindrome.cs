using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    class _04PermutationPalindrome
    {
        public static bool PermutationPalindrome(string input)
        {
            int[] arr = new int[26];

            input = input.ToLower().Replace(" ", "");

            for (int i = 0; i < input.Length; i++)
            {
                arr[input[i] - 'a']++;
            }

            int odd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    odd++;

                    if (odd >= 2) return false;
                }
            }

            return true;
        }

        //public static void Main()
        //{
        //    //string input = "tacoctaa";
        //    string input = "Tact Coa";
        //    Console.WriteLine(PermutationPalindrome(input));
        //    Console.ReadLine();
        //}
    }
}
