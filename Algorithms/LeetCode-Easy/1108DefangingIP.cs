using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _1108DefangingIP
    {
        public static string DefangIPaddr(string address)
        {
            StringBuilder newString = new StringBuilder();

            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '.')
                {
                    newString.Append(new char[] { '[', address[i], ']' });
                }
                else
                {
                    newString.Append(address[i]);
                }
            }

            return newString.ToString();
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(DefangIPaddr("255.100.101.0"));
        //    Console.ReadLine();
        //}
    }
}
