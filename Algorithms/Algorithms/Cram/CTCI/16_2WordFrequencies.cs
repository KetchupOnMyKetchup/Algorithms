using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithms.Algorithms.Cram.CTCI
{
    /// <summary>
    /// Design a method to find the frequency of occurrences of any given word in a book. 
    /// What if we were running this algorithm multiple times?
    /// </summary>
    class _16_2WordFrequencies
    {
        public static int GetFrequency(string bookText, string word)
        {
            //char[] specialCharToRemove = new char[] { ',', '.', '!', '?', ':', ';'};
            string noSpecialCharBookText = RemoveSpecialCharacters(bookText);

            string[] bookArray = noSpecialCharBookText.Split(" ");

            var table = FindFreqencyHashTable(bookArray);

            if (table == null) return -1;

            var success = table.TryGetValue(word, out int value);

            return value;
        }

        static string RemoveSpecialCharacters(string str)
        {
            string removePeriods = str.Replace(".", string.Empty);
            return Regex.Replace(removePeriods, "[^a-zA-Z0-9_.]+", " ", RegexOptions.Compiled);
        }

        //static string LINQRemoveSpecialCharacters(string value, char[] specialCharacters)
        //{
        //    return new String(value.Except(specialCharacters).ToArray());
        //}

        static Dictionary<string, int> FindFreqencyHashTable(string[] book)
        {
            Dictionary<string, int> table = new Dictionary<string, int>();

            foreach (var word in book)
            {
                string lowerCaseWord = word.ToLower();

                if (lowerCaseWord.Trim() != "")
                {
                    if (!table.ContainsKey(lowerCaseWord))
                    {
                        table.Add(lowerCaseWord, 1);
                    }
                    else
                    {
                        table[lowerCaseWord] = table[lowerCaseWord] + 1;
                    }
                }
                
            }

            return table;
        }
        
        //public static void FindFrequency(string word, string bookText)
        //{
        //    string[] textArray = bookText.ToLower().Split(" ");

        //    int count = 0;

        //    foreach (var item in textArray)
        //    {
        //        if (item.Contains(word))
        //        {
        //            count++;
        //        }
        //    }

        //    Console.WriteLine($"The word {word} has been found {count} time(s) in the given text.");
        //    Console.ReadLine();

        //}

        //static void Main(string[] args)
        //{
        //    string bookText = "In practice, a writer can get too caught up in all the things " +
        //        "they have to say and fail to organize it all into bits an ordinary human being " +
        //        "would be able to digest. The end result is a huge run-on paragraph that makes it " +
        //        "difficult to recall the original point of it if there was one in the first place. " +
        //        "The reader's eyes glaze over and all they see is a wall of text.";

        //    //_16_2WordFrequencies.FindFrequency("and", bookText); // 2
        //    //_16_2WordFrequencies.FindFrequency("place", bookText); // 1
        //    _16_2WordFrequencies.GetFrequency(bookText, "text"); // 1
        //}
    }
}
