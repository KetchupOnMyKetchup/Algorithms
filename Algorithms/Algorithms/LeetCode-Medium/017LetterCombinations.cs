using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _017LetterCombinations
    {
        static Dictionary<string, string> phone = new Dictionary<string, string>
            {
                { "2", "abc" },
                { "3", "def" },
                { "4", "ghi" },
                { "5", "jkl" },
                { "6", "mno" },
                { "7", "pqrs" },
                { "8", "tuv" },
                { "9", "wxyz" }
            };

        static List<string> output = new List<string>();

        public static void BackTrack(string combination, string next_digits)
        {
            if (next_digits.Length == 0) output.Add(combination);
            else
            {
                string digit = next_digits.Substring(0, 1);
                string letters = phone[digit];

                for (int i = 0; i < letters.Length; i++)
                {
                    string letter = phone[digit].Substring(i, 1);
                    BackTrack(combination + letter, next_digits.Substring(1));
                }
            }
        }

        public static List<string> LetterCombinations(string digits)
        {
            if (digits.Length != 0)
                BackTrack("", digits);
            return output;
        }

        //public static void Main()
        //{
        //    string digits = "234";
        //    var list = LetterCombinations(digits);

        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();
        //}
    }
}
