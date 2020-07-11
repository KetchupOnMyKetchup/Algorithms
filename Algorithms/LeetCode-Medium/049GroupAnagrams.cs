using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode_Medium
{
    class _049Anagrams
    {
        //public static void Main()
        //{
        //    GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        //}

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> result = new List<IList<string>>();

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                char[] temp = str.ToCharArray();
                Array.Sort(temp);
                string sorted = temp.ToString();

                if (!dict.ContainsKey(sorted)) dict.Add(sorted, new List<string>());

                dict[sorted].Add(str);
            }

            foreach (var pair in dict)
            {
                result.Add(new List<string>(pair.Value));
            }

            return result;
        }
    }
}
