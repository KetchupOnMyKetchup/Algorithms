using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _022GenerateParenthesis
    {
        //static void Main()
        //{
        //    int num = 3;

        //    List<string> result = GenerateParenthesis(num);

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();
        //}

        private static List<string> GenerateParenthesis(int num)
        {
            List<string> list = new List<string>();
            Backtrack(list, "", 0, 0, num);
            return list;
        }

        public static void Backtrack(List<string> list, string str, int open, int close, int max)
        {
            if (str.Length == max * 2)
            {
                list.Add(str);
                return;
            }

            if (open < max)
                Backtrack(list, str + "(", open + 1, close, max);
            if (close < open)
                Backtrack(list, str + ")", open, close + 1, max);
        }
    }
}
