using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class NeedleInAHaystack
    {
        public static int StrStr(string haystack, string needle)
        {
            if (needle == String.Empty) return 0;
            if (haystack == String.Empty) return -1;

            int lengthNeedle = needle.Length;
            int haystackLength = haystack.Length;

            if (lengthNeedle > haystackLength) return -1;

            // see if first leter matches anywhere
            for (int i = 0; i < haystackLength - lengthNeedle + 1; i++)
            {
                bool IsFound = false;

                // start at end of haystack
                for (int j = 0, temp = i; j < lengthNeedle && temp < haystackLength; j++, temp++)
                {
                    IsFound = true;
                    if (haystack[temp] != needle[j])
                    {
                        IsFound = false;
                        break;
                    }
                }
                
                if (IsFound) return i;
            }

            return -1;
        }


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(StrStr("hello", "ll"));
        //    //Console.WriteLine(StrStr("mississippi", "mississippi"));
        //    //Console.WriteLine(StrStr("Needle in a big autumn haystack of leaves.", "haystack"));
        //    Console.ReadLine();
        //}
    }
}


