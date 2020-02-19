using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class GroupAnagrams1
    {
        static void Main()
        {
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result = GroupAnagrams(strs);
        }


        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] arr = strs[i].ToCharArray();
                Array.Sort(arr);
                string sorted = new string(arr);

                if (dict.ContainsKey(sorted))
                {
                    dict[sorted].Add(strs[i]);
                }
                else
                {
                    dict.Add(sorted, new List<string>() { strs[i] });
                }
            }

            return new List<IList<string>>(dict.Values);
        }
    }
}
