using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Hard
{
    class _010RegularExpressionMatching
    {
        private class Node
        {
            public Node(char value)
            {
                Value = value;
            }
            public char Value { get; set; }
            public bool IsAsterik { get; set; }
        }
        
        private static bool RegexMatching(string s, string p)
        {
            if (p.Length == 0 && s.Length == 0) return true;

            List<Node> array = new List<Node>();

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '*') array[array.Count - 1].IsAsterik = true;
                else array.Add(new Node(p[i]));
            }

            int count = 0;

            for (int i = 0; i < s.Length;)
            {
                if (count > array.Count - 1) return false;

                if (array[count].Value == '.')
                {
                    if (array[count].IsAsterik)
                    {
                        if (count == array.Count - 1) return true;
                        else
                        {
                            while (s[i] != array[count].Value)
                            {
                                i++;

                                if (i >= s.Length - 1)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    else
                    {
                        count++;
                        i++;
                    }
                }
                else if (s[i] != array[count].Value)
                {
                    if (array[count].IsAsterik) count++;
                    else return false;
                }
                else if (array[count].IsAsterik) i++;
                else
                {
                    i++;
                    count++;
                }
            }

            return true;
        }

        public static void Main()
        {
            //    string s = "ab";
            //    string p = ".*c";

            string s = "mississippi";
            string p = "mis*is*p*.";

            //string s = "aa";
            //string p = "a";

            //string s = "b";
            //string p = "a*b";

            //string s = "ab";
            //string p = ".*";

            Console.WriteLine(RegexMatching(s, p));
            Console.ReadLine();
        }
    }
}
