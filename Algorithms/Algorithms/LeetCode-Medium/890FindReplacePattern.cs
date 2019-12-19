using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _890FindReplacePattern
    {
        public static IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            List<string> finalList = new List<string>();


            foreach (var word in words)
            {
                if (word.Length != pattern.Length) continue;

                bool matchesPattern = CheckPattern(pattern, word);

                if (matchesPattern) finalList.Add(word);
            }

            return finalList;
        }

        // TWO ARRAYS, since const space 26 sized array... may as well make 2 of them, doesn't affect O notation for space
        private static bool CheckPattern(string pattern, string word)
        {
            char[] keyToValue = new char[26];
            char[] valueToKey = new char[26];

            for (int a = 0; a < 26; a++) keyToValue[a] = '\0';
            for (int b = 0; b < 26; b++) valueToKey[b] = '\0';

            for (int i = 0; i < pattern.Length; i++)
            {
                if (keyToValue[pattern[i] - 'a'] == '\0')
                {
                    if (valueToKey[word[i] - 'a'] != '\0') return false;

                    keyToValue[pattern[i] - 'a'] = word[i];
                    valueToKey[word[i] - 'a'] = pattern[i];
                }
                else
                {
                    if (keyToValue[pattern[i] - 'a'] != word[i]) return false;
                }
            }

            return true;
        }

        // ONE ARRAY
        //private static bool CheckPattern(string pattern, string word, char[] arr)
        //{
        //    char[] arr = new char[26];
        //    for (int z = 0; z < 26; z++) arr[z] = '\0';

        //    for (int i = 0; i < pattern.Length; i++)
        //    {
        //        if (arr[pattern[i] - 'a'] == '\0')
        //        {
        //            for (int j = 0; j < 26; j++)
        //            {
        //                if (arr[j] == word[i]) return false;
        //            }

        //            arr[pattern[i] - 'a'] = word[i];
        //        }
        //        else
        //        {
        //            if (arr[pattern[i] - 'a'] != word[i]) return false;
        //        }
        //    }

        //    return true;
        //}

        // USING DICTIONARY
        //private static bool CheckPattern(string pattern, string word)
        //{
        //    Dictionary<char, char> dict = new Dictionary<char, char>();

        //    for (int i = 0; i < pattern.Length; i++)
        //    {
        //        if (!dict.ContainsKey(pattern[i]))
        //        {
        //            if (dict.ContainsValue(word[i])) return false;
        //            dict.Add(pattern[i], word[i]);
        //        }
        //        else
        //        {
        //            if (dict[pattern[i]] != word[i]) return false;
        //        }
        //    }

        //    return true;
        //}

        //public static void Main()
        //{
        //    string[] words = new string[6] { "aqq", "deq", "mee", "aqq", "dkd", "ccc" };
        //    string pattern = "abb";

        //    Console.Write(FindAndReplacePattern(words, pattern).Count);
        //    Console.ReadLine();
        //}
    }
}
