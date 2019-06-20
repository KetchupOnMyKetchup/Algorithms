using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.Ad_hoc
{

    public class ReverseWordsSolution
    {
        //static void Main()
        //{
        //    var str = new[] { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' };
        //    ReverseWords(str);
        //    //Assert.AreEqual(new[] { 'b', 'l', 'u', 'e', ' ', 'i', 's', ' ', 's', 'k', 'y', ' ', 't', 'h', 'e' },
        //    //    str);
        //}


        public static void ReverseWords(char[] str)
        {
            int start = 0;
            for (int end = 0; end < str.Length; end++)
            {
                while (end < str.Length && str[end] != ' ') //find the break point with the space
                    end++;
                Reverse(str, start, end - 1); // end is the space, reverse the word
                start = end + 1; // go to the start of the next word
            }

            Reverse(str, 0, str.Length - 1); // reverse the entire array
        }

        static void Reverse(char[] str, int start, int end)
        {
            while (start < end)
            {
                char temp = str[start];
                str[start] = str[end];
                str[end] = temp;
                start++;
                end--;
            }

        }
    }
}
