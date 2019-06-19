using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.HackerNoon
{
    class _004CheckStringAnagrams
    {
        static void Solve(string string1, string string2)
        {
            // Reverse string
            StringBuilder sb = new StringBuilder();

            for (int i = string1.Length - 1; i >= 0; i--)
            {
                sb.Append(string1[i]);
            }

            // check if same
            if (sb.ToString() == string2)
            {
                Console.WriteLine($"Strings are anagrams, string2 is {string2}");
            }
            else
            {
                Console.WriteLine($"Strings are not anagrams");
            }
        }

        //static void Main()
        //{
        //    string string1 = "TacocaaTT";
        //    string string2 = "TTaacocaT";
        //    Solve(string1, string2);
        //    Console.ReadLine();
        //}
    }
}
