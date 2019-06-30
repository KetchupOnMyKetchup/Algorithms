using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class ValidParenthesis
    {
        public static bool IsValid(string s)
        {
            // can be an empty string (edge case)
            if (s.Length == 0) return true;

            // can be alone, or multiple types on their own
            Dictionary<char, char> pairs = new Dictionary<char, char>();
            pairs.Add('(', ')');
            pairs.Add('[', ']');
            pairs.Add('{', '}');

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (pairs.TryGetValue(s[i], out char value)) // if we have value
                {
                    stack.Push(value); // push its pair into the stack
                }
                else // if we are given an end piece
                {
                    if (stack.Count == 0 || s[i] != stack.Pop()) return false; // and if it doesn't match or we're given an end piece first, then we fail
                }
            }

            // edge case: no closing "["
            if (stack.Count != 0) return false;

            return true;
        }

        //static void Main(string[] args)
        //{
        //    //string input = "()";
        //    //string input = "({[]})";
        //    //string input = "({[}]})";
        //    //string input = "}()";
        //    //string input = "[]{}()";
        //    string input = "[";

        //    Console.WriteLine($"The input {input} is: {IsValid(input)}");
        //    Console.ReadLine();
        //}
    }
}
