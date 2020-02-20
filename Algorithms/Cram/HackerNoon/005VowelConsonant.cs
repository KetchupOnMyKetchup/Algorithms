using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.HackerNoon
{

    /// <summary>
    /// How do you count a number of vowels and consonants in a given string?
    /// </summary>
    class _005VowelConsonant
    {
        static void Solve(string test)
        {
            int vowelCount = 0;

            foreach (var item in test.ToCharArray())
            {
                switch (item)
                {
                    case 'a': 
                    case 'e': 
                    case 'i': 
                    case 'o': 
                    case 'u':
                        vowelCount++;
                        break;
                    default:
                        break;
                }
            }

            int length = test.Length;

            Console.WriteLine($"The number of vowels is {vowelCount} and consonants is {length - vowelCount}.");

        }

        //static void Main()
        //{
        //    //string test = "nkjahdihqwnbkfdhishbfkhiualowueiihibvasdgfowqpioe";
        //    string test = "eeeeellllll";
        //    Solve(test);
        //    Console.ReadLine();
        //}
    }
}
