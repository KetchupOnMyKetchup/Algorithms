using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithms.CSharp
{
    class CommonRegex
    {
        static void RegexStringOnly(string input)
        {
            // international: Regex.IsMatch(theString, @"^[\p{L}]+$");

            // a-z
            bool matches = Regex.IsMatch(input, @"^[a-zA-Z]+$", RegexOptions.IgnoreCase);
        }

        static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        static void RegexLettersAndNumOnly(string input)
        {
            // international: Regex.IsMatch(theString, @"^[\p{L}\p{N}]+$");

            // a-z
            bool matches = Regex.IsMatch(input, @"^[a-zA-Z0-9]+$", RegexOptions.IgnoreCase);
        }

        static bool IsAllLettersOrDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

        static void RegexNumOrLettersOrUnderscores(string input)
        {
            // international: Regex.IsMatch(theString, @"^[\w]+$");

            // a-z
            Regex.IsMatch(input, @"^[a-zA-Z0-9_]+$");
        }

        static bool IsAllLettersOrDigitsOrUnderscores(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c) && c != '_')
                    return false;
            }
            return true;
        }

        static void RemoveAllSpecialChar(string input)
        {
            Regex.Replace(input, @"[^0-9a-zA-Z]+", "");

            // remove all except comma and colon
            Regex.Replace(input, @"[^0-9a-zA-Z:,]+", "");
        }
    }
}
