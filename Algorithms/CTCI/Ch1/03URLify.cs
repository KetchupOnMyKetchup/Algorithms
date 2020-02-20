using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.CTCI.Ch1
{
    class _03URLify
    {
        public static string URLify(string input, int lengthWord)
        {
            int index = input.Length - 1;

            char[] arr = input.ToCharArray();

            for (int i = lengthWord - 1; i >= 0; i--)
            {
                if (arr[i] != ' ')
                {
                    arr[index] = arr[i];
                    index--;
                }
                else
                {
                    arr[index] = '0';
                    arr[index - 1] = '2';
                    arr[index - 2] = '%';

                    index -= 3;
                }
            }

            return new string(arr);
        }

        //public static void Main()
        //{
        //    string input = "Mr John Smith    ";
        //    Console.WriteLine(URLify(input, 13));
        //    Console.ReadLine();
        //}

        //StringBuilder finalString = new StringBuilder();

        //foreach (var letter in input)
        //{
        //    if (letter != ' ')
        //    {
        //        finalString.Append(letter);
        //    }
        //    else
        //    {
        //        finalString.Append("%20");
        //    }
        //}

        //return finalString.ToString();
    }
}
