using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.Cram.Ad_hoc
{
    class LongestPalindrome
    {

        public static string FindLongestPalindrome(string input)
        {
            var longest = (start: 0, end: 0);

            for (int i = 0; i < input.Length; i++)
            {
                longest = Max(longest, GetPalindromeAt(i, input));
            }

            return input.Substring(longest.start, longest.end - longest.start + 1);
        }

        public static (int start, int end) GetPalindromeAt(int position, string input)
        {
            var longest = (start: position, end: position);

            foreach (var lowerStart in new[] { position - 1, position })
            {
                var lower = lowerStart;
                var upper = position + 1;
                while (lower >= 0 &&
                          upper < input.Length &&
                          input[lower] == input[upper])
                {
                    upper++;
                    lower--;
                }
                longest = Max(longest, (lower + 1, upper - 1));
            }
            return longest;
        }

        public static (int, int) Max((int start, int end) a, (int start, int end) b)
        {
            return a.end - a.start > b.end - b.start ? a : b;
        }

        //static void Main()
        //{
        //    string input = "my name is abba tacocat the exploding kitten";

        //    var result = FindLongestPalindrome(input);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
    }
}
