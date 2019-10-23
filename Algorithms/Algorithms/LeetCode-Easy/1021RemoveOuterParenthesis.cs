using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _1021RemoveOuterParenthesis
    {
        public static string RemoveOuterParentheses(string S)
        {
            StringBuilder s = new StringBuilder();

            int opened = 0;

            foreach (var c in S.ToCharArray())
            {
                if (c == '(' && opened++ > 0) s.Append(c);
                if (c == ')' && opened-- > 1) s.Append(c);
            }

            return s.ToString();
        }

        //public static void Main()
        //{
        //    string S1 = "((()())(()())";
        //    string S2 = "(()()()())";
        //    string S3 = "()()()()";

        //    Console.WriteLine(RemoveOuterParentheses(S1));
        //    Console.WriteLine(RemoveOuterParentheses(S2));
        //    Console.WriteLine(RemoveOuterParentheses(S3));
        //    Console.ReadLine();
        //}
    }
}
