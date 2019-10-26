using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.Ad_hoc
{
    class RomanNumerals
    {
        static Dictionary<char, int> dict = new Dictionary<char, int>();

        public static int RomanToInt(string s) // IV = 4, VII = 7
        {
            if (dict.Count == 0) SeedDictionary();
            
            int result = 0;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && CheckSpecialCase(s[i], s[i + 1]))
                {
                    stack.Push(dict.GetValueOrDefault(s[i + 1]) - dict.GetValueOrDefault(s[i]));
                    i++;
                }
                else
                {
                    stack.Push(dict.GetValueOrDefault(s[i]));
                }
            }

            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            return result;
        }

        private static bool CheckSpecialCase(char x, char y)
        {
            if (dict.GetValueOrDefault(x) < dict.GetValueOrDefault(y)) return true;
            return false;
        }

        private static void SeedDictionary()
        {
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(RomanToInt("IV"));
        //    Console.WriteLine(RomanToInt("VII"));
        //    Console.WriteLine(RomanToInt("IV"));
        //    Console.WriteLine(RomanToInt("LVIII"));
        //    Console.WriteLine(RomanToInt("MCMXCIV"));
        //    Console.ReadLine();
        //}
    }
}
