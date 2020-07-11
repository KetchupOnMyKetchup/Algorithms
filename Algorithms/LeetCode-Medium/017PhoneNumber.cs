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
            // call helper
            List<string> result = new List<string>();
            if (digits.Length == 0) return result;

            Helper(result, digits, 0, new StringBuilder());

            return result;
        }

        // make helper: result, digits, index am on, temp string
        public static void Helper(List<string> result, string digits, int index, StringBuilder temp)
        {
            // length to stop at and add to result string
            if (index == digits.Length)
            {
                result.Add(temp.ToString());
                return;
            }
            // for loop
            string currLetters = dict[digits[index]];

            for (int j = 0; j < currLetters.Length; j++)
            {
                temp.Append(currLetters[j]);
                Helper(result, digits, index + 1, new StringBuilder());
                temp.Remove(temp.Length - 1, 1);
            }

        }


        //public static IList<string> LetterCombinations(string digits)
        //{
        //    List<string> finalResult = new List<string>();

        //    if (digits.Length == 0) return finalResult;

        //    BackTrack(finalResult, digits, 0, new StringBuilder(""));

        //    return finalResult;
        //}

        //public static void BackTrack(List<string> finalResult, string digits, int currentIndex, StringBuilder partialMnemonic)
        //{
        //    // Constraints: we could run out of numbers
        //    // if no letters left, return
        //    if (currentIndex == digits.Length)
        //    {
        //        finalResult.Add(partialMnemonic.ToString());
        //        return;
        //    }

        //    // Choice: one letter at a time per #
        //    foreach (var letter in dict[digits[currentIndex]])
        //    {
        //        partialMnemonic.Append(letter);

        //        BackTrack(finalResult, digits, currentIndex + 1, partialMnemonic);

        //        partialMnemonic.Remove(partialMnemonic.Length - 1, 1);
        //    }

        //    // Goal: Get full list of letters possible
        //}
    }
}
