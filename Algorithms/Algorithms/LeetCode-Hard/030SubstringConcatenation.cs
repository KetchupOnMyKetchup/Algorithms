using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Hard
{
    class _030SubstringConcatenation
    {
        public static void Main()
        {
            string[] words = new string[] { "word", "good", "best", "good" };
            var result = FindSubstring("wordgoodgoodgoodbestword", words);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        // Working solution but too slow, passes 148/170 tests but not all
        public static IList<int> FindSubstring(string s, string[] words)
        {
            List<int> list = new List<int>();

            if (string.IsNullOrEmpty(s) || words.Length == 0) return list;

            HashSet<int> possibleHashes = new HashSet<int>();
            GetAllWordCombinations(possibleHashes, words.ToList(), new List<string>());

            int hashLength = words[0].Length * words.Length;

            for (int i = 0; i <= s.Length - hashLength; i++)
            {
                string substring = s.Substring(i, hashLength);
                int tempHash = substring.GetHashCode();
                if (possibleHashes.Contains(tempHash)) list.Add(i);
            }

            return list;
        }

        private static void GetAllWordCombinations(HashSet<int> possibleHashes, List<string> words, List<string> tempList)
        {
            if (words.Count == 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in tempList) sb.Append(item);
                string final = sb.ToString();
                possibleHashes.Add(final.GetHashCode());
            }

            for (int i = 0; i < words.Count; i++)
            {
                tempList.Add(words[i]);
                words.RemoveAt(i);

                GetAllWordCombinations(possibleHashes, words, tempList);
                
                words.Insert(i, tempList[tempList.Count - 1]);
                tempList.RemoveAt(tempList.Count - 1);
            }

        }
    }
}
