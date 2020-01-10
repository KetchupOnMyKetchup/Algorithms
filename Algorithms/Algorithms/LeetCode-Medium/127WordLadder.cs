using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _127WordLadder
    {
        //public static void Main()
        //{
        //    IList<string> wordList = new List<string>() {"hot", "dot", "dog", "lot", "log", "cog"};

        //    var result = LadderLength("hit", "cog", wordList);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        // https://leetcode.com/problems/word-ladder/discuss/40704/Java-Solution-using-BFS-with-explanation
        // does not pass all unit tests with java or C#, see other solution that is commented out or solution tab in leetcode
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> reached = new HashSet<string>();

            reached.Add(beginWord);
            wordList.Add(endWord);
            int distance = 1;

            while (!reached.Contains(endWord))
            {
                HashSet<string> toAdd = new HashSet<string>();
                foreach (var item in reached)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        char[] chars = item.ToCharArray();

                        for (char ch = 'a'; ch <= 'z'; ch++)
                        {
                            chars[i] = ch;
                            string word = new string(chars);

                            if (wordList.Contains(word))
                            {
                                toAdd.Add(word);
                                wordList.Remove(word);
                            }

                        }
                    }
                }
                distance++;
                if (toAdd.Count == 0) return 0;
                reached = toAdd;
            }
            return distance;
        }

        //class Word
        //{
        //    public Word(string word, int distanceFromStart)
        //    {
        //        Value = word;
        //        DistanceFromStart = distanceFromStart;
        //        LinkedWords = new List<Word>();
        //    }

        //    public string Value { get; set; }
        //    public List<Word> LinkedWords { get; set; }
        //    public int DistanceFromStart { get; set; }
        //}

        //public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        //{
        //    // Set start word
        //    Word start = new Word(beginWord, 1);
        //    Word curr = start;

        //    // Loop over other words
        //    return Recurse(endWord, wordList, curr, "");
        //}

        //private static int Recurse(string endWord, IList<string> wordList, Word curr, string prev)
        //{
        //    // test if can get to end word
        //    if (Is1SubstitutionAway(curr, endWord)) 
        //        return curr.DistanceFromStart + 1;

        //    foreach (var word in wordList)
        //    {
        //        if (Is1SubstitutionAway(curr, word)) // See if 1 substitution away
        //        {
        //            if (prev == word) continue; // prevent circular loop **TODO make more hardy than prev, prevent cyclic like last problem
        //            curr.LinkedWords.Add(new Word(word, ++curr.DistanceFromStart));
        //        }

        //    }

        //    foreach (var nextWord in curr.LinkedWords)
        //    {
        //        Recurse(endWord, wordList, nextWord, curr.Value);
        //    }

        //    return 0;
        //}

        //private static bool Is1SubstitutionAway(Word curr, string word)
        //{
        //    int count = 0;

        //    for (int i = 0; i < curr.Value.Length; i++)
        //    {
        //        for (int j = 0; j < word.Length; j++)
        //        {
        //            if (curr.Value[i] == word[j]) count++;
        //        }
        //    }

        //    if (count == curr.Value.Length - 1) return true;
        //    return false;
        //}
    }
}
