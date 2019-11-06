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

        public static bool isMatch(String s, String p)
        {
            if (string.IsNullOrEmpty(p)) return string.IsNullOrEmpty(s);

            bool first_match = (!string.IsNullOrEmpty(s) &&
                                   (p[0] == s[0] || p[0] == '.'));

            if (p.Length >= 2 && p[1] == '*')
            {
                return (isMatch(s, p.Substring(2)) ||
                        (first_match && isMatch(s.Substring(1), p)));
            }
            else
            {
                return first_match && isMatch(s.Substring(1), p.Substring(1));
            }
        }

        private static bool RegexMatching(string s, string p)
        {
            if (p.Length == 0 && s.Length != 0) return false;
            if (p.Length == 0 && s.Length == 0) return true;

            List<Node> array = new List<Node>();
            int count = 0;

            //if its a *, then set previous node to true

            for (int i = 0; i < p.Length; i++)
            {
                var tempNode = new Node(p[i]);

                //if (p[i] == '*')
                //{
                //    array
                //    i++;
                //}

                array[count] = tempNode;
                count++;
            }

            count = 0;

            for (int i = 0; i < s.Length;)
            {
                if (array[count] == null) return false; // remove

                if (array[count].Value == '.')
                {
                    count++;
                    i++;
                }
                else if (s[i] != array[count].Value)
                {
                    if (array[count].IsAsterik) // i > 0 && array[count].IsAsterik && s[i - 1] == array[count].Value) || 
                    {
                        count++;
                        continue;
                    }
                    else return false;
                }
                else i++;
            }

            return true;
        }

        //public static void Main()
        //{
        //    string s = "aaab";
        //    string p = "a*b";

        //    //string s = "b";
        //    //string p = "a*b";

        //    //string s = "ab";
        //    //string p = ".*";

        //    Console.WriteLine(isMatch(s, p));
        //    Console.ReadLine();
        //}
    }
}
