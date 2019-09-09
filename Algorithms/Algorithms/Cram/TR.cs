using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.Cram
{
    class TR
    {
        //static string asdf(string lastName, bool isWoman, bool isKnighted)
        //{
        //    if (lastName == string.Empty) return string.Empty;
        //    string gender = isWoman ? "Ms. " : "Mr. ";

        //    string knight = "";

        //    if (isWoman && isKnighted) knight = "Dame ";
        //    if (!isWoman && isKnighted) knight = "Sir ";
        //    if (isWoman && !isKnighted) knight = "Ms.  ";
        //    if (!isWoman && !isKnighted) knight = "Mr. ";

        //    return $"Hello {knight}{lastName}";
        //}

        //static string WhatTime(int seconds)
        //{
        //    // 1800 secondsTimeSpan 
        //    var t = TimeSpan.FromSeconds(seconds);
        //    string result = t.ToString(@"h\:m\:s");

        //    return result;
        //}

        public static string RestoreSpaces(string[] dictionary, string message)
        {
            string sb = "";

            int startLetter = 0;
            int lengthWord = 1;

            for (int i = 0; i < message.Length; i++)
            {
                string testWord = message.Substring(startLetter, lengthWord);
                lengthWord++;

                //CheckIfWord
                foreach (var item in dictionary)
                {
                    if (testWord == item)
                    {
                        // Found word
                        sb += (testWord);
                        sb += (" ");

                        startLetter = startLetter + lengthWord - 1;
                        lengthWord = 1;
                        break;
                    }
                }

            }

            string result = sb.ToString().TrimEnd(' ');

            return result;
        }
        //static int GetCount(int min, int max)
        //{
        //    int count = 0;

        //    for (int i = min; i <= max; i++)
        //    {
        //        if (Math.Sqrt(i) % 1 != 0)
        //        {
        //            count++;
        //        }

        //    }

        //    return count;

        //}

        //static void Main()
        //{
        //    //Calculate(3);
        //    //Console.WriteLine(asdf("Tenn", false, true));
        //    //Console.WriteLine(asdf("", false, false));
        //    //WhatTime(100);

        //    //RestoreSpaces(new string[] { "hi", "you" }, "hiyou");

        //    GetCount(-5, 5);

        //    Console.ReadLine();
        //}


    }
}
