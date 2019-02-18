using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank.Medium
{
    public class EnglishText
    {
        // Complete the encryption function below.
        static string encryption(string s)
        {
            // remove all spaces
            string newString = s.Replace(" ", "");

            // find the length of the string
            int length = newString.Length;

            // find the square root of the length
            double squareRoot = Math.Sqrt(length);

            int upper = (int)Math.Ceiling(squareRoot);
            int lower = (int)squareRoot;

            // linebreak every "n" characters
            var splitUp = Split(newString.Length, upper);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < upper; i++)
            {
                if (sb.Length > 0) sb.Append(" ");

                foreach (var lineStart in splitUp)
                {
                    var pos = lineStart + i;
                    if (pos < newString.Length) sb.Append(newString[pos]);
                }
            }

            return sb.ToString();
        }

        //// str = feedthedog
        //static IEnumerable<string> Split(string str, int chunkSize)
        //{
        //    // 3 = Ceiling(10 / 4)
        //    var chunks = (int)Math.Ceiling(str.Length / (double)chunkSize);

        //    return Enumerable.Range(0, chunks)
        //        .Select(i => i == chunks - 1
        //            ? str.Substring(i * chunkSize) // og
        //            : str.Substring(i * chunkSize, chunkSize)); // feed, thed
        //}

        // str = feedthedog
        static IEnumerable<int> Split(int length, int chunkSize)
        {
            // 3 = Ceiling(10 / 4)
            var chunks = (int)Math.Ceiling(length / (double)chunkSize);

            //List<int> list = new List<int>();
            //for (int i = 0; i < chunks; i++)
            //{
            //    list[i] = i * chunkSize;
            //}

            return Enumerable.Range(0, chunks)
                .Select(i => i * chunkSize); // feed, thed, og
        }

        //static void Main(string[] args)
        //{
        //    string s = Console.ReadLine();

        //    string result = encryption(s);
        //}
    }
}
