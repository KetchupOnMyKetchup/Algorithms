using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.HackerNoon
{
    /// <summary>
    /// How do you count the occurrence of a given character in a string? 
    /// </summary>
    class _006CharOccurrence
    {
        static void Solve(string sampleText)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var item in sampleText)
            {
                //bool getValue = dict.TryGetValue(item, out int value);

                if (dict.ContainsKey(item))
                {
                    //dict[item] += 1;
                    //dict[item] = value + 1;
                    //dict[item] = ++value;
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

        }

        //static void Main()
        //{
        //    string sampleText = "jsndfkjan sdahjfoijfwef sjfdsdj flskjflosidjfew poim zlmcn";
        //    Solve(sampleText);
        //}
    }
}
