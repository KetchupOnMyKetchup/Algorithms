using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _139WordBreak
    {
        //static void Main()
        //{

        //    //List<string> wordDict = new List<string>() { "leet", "code" };
        //    List<string> wordDict = new List<string>() { "aaa", "aaaa" };

        //    //var result = WordBreak("leetcode", wordDict);
        //    var result = WordBreak("aaaaaaa", wordDict);
        //    Console.WriteLine(result);
        //}

        public static bool WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> wordDictSet = new HashSet<string>(wordDict);

            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            
            for (int r = 1; r <= s.Length; r++)
            {
                for (int l = 0; l < r; l++) // need double for loop to check all possibilities in word DictSet so if it matches the beginning of a word it doesnt stop thre
                    // for example aaa and aaaa .. or bat and bats .. or dog and dogsled
                {
                    string temp = s.Substring(l, r - l);

                    if (dp[l] && wordDictSet.Contains(temp))
                    {
                        dp[r] = true; // mark true where a new word could start. if 1st word is from index 0 to 3 and 3 letters long, mark index 4 true
                        break;
                    }
                }
            }
            return dp[s.Length];
        }
    }
}
