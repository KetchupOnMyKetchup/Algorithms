using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LeetCode_Easy
{
    class _844BSSC
    {
        //public static void Main()
        //{
        //    BackspaceCompare("a##c", "#a#c");
        //}

        public static bool BackspaceCompare(string S, string T)
        {
            int si = S.Length - 1;
            int ti = T.Length - 1;

            // # backspaces
            int sb = 0;
            int tb = 0;

            // start on right, go left.
            while (si >= 0 || ti >= 0)
            {
                // if #, start counting # backspaces. 
                if (si >= 0 && S[si] == '#')
                {
                    sb++;
                    si--;
                }
                else if (ti >= 0 && T[ti] == '#')
                {
                    tb++;
                    ti--;
                }

                // if backspace > 0, then skip char and backspace--
                else if (sb > 0)
                {
                    sb--;
                    si--;
                }
                else if (tb > 0)
                {
                    tb--;
                    ti--;
                }
                // if they equal, decrement
                else if (si >= 0 && ti >= 0 && S[si] == T[ti])
                {
                    si--;
                    ti--;
                }
                else return false;
            }

            return (si == ti);
        }
    }
}
