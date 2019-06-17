using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.CTCI
{
    /// <summary>
    /// Given any integer, print an English phrase that describes the integer (e.g., "One Thousand,
    /// Two Hundred Thirty Four").
    /// </summary>
    class _16_8EnglishInt
    {
        private static readonly string[] Ones = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        private static readonly string[] Teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private static readonly string[] Tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private static readonly string[] Big = { "Hundred", "Thousand", "Million", "Billion" };

        static string TranslateIntToEnglish(int number)
        {
            var result = new Stack<string>();

            if (number < 10) return Ones[number];

            int bigNum = 0;
            while (number > 0 && bigNum < Big.Length)
            {
                int curr = number % 1000; //
                if (curr > 0)
                {
                    if (bigNum > 0)
                    {
                        result.Push(Big[bigNum]);
                    }

                    result = NumberToWords(result, curr);

                    number /= 1000;
                    bigNum++;
                }
            }

            return string.Join(" ", result);
        }

        static Stack<string> NumberToWords(Stack<string> result, int curr)
        {
            int ones = curr % 10; 
            int tens = curr % 100 / 10; 
            int hundreds = curr / 100;

            if (tens == 1)
            {
                result.Push(Teens[ones]);
            }
            else
            {
                if (ones > 0)
                {
                    result.Push(Ones[ones]);
                }
                if (tens > 1)
                {
                    result.Push(Tens[tens]);
                }
            }

            if (hundreds > 0)
            {
                result.Push(Big[0]);
                result.Push(Ones[hundreds]);
            }

            return result;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(_16_8EnglishInt.TranslateIntToEnglish(0));
        //    Console.WriteLine(_16_8EnglishInt.TranslateIntToEnglish(1));
        //    Console.WriteLine(_16_8EnglishInt.TranslateIntToEnglish(12));
        //    Console.WriteLine(_16_8EnglishInt.TranslateIntToEnglish(44));
        //    Console.WriteLine(_16_8EnglishInt.TranslateIntToEnglish(101));
        //    Console.WriteLine(_16_8EnglishInt.TranslateIntToEnglish(2500));
        //    Console.WriteLine(_16_8EnglishInt.TranslateIntToEnglish(123456789));
        //    Console.ReadLine();
        //}
    }
}
