using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _017PhoneNumber
    {
        //public static void Main()
        //{
        //    string digits = "23";

        //    var result = LetterCombinations(digits);

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();
        //}

        static Dictionary<char, string> dict = new Dictionary<char, string>() 
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" },
        };


        public static IList<string> LetterCombinations(string digits)
        {
            List<string> finalResult = new List<string>();

            if (digits.Length == 0) return finalResult;

            BackTrack(finalResult, digits, 0, new StringBuilder(""));

            return finalResult;
        }

        public static void BackTrack(List<string> finalResult, string digits, int currentIndex, StringBuilder partialMnemonic)
        {
            // Constraints: we could run out of numbers
            // if no letters left, return
            if (currentIndex == digits.Length)
            {
                finalResult.Add(partialMnemonic.ToString());
                return;
            }

            // Choice: one letter at a time per #
            foreach (var letter in dict[digits[currentIndex]])
            {
                partialMnemonic.Append(letter);

                BackTrack(finalResult, digits, currentIndex + 1, partialMnemonic);

                partialMnemonic.Remove(partialMnemonic.Length - 1, 1);
            }

            // Goal: Get full list of letters possible
        }
    }
}
