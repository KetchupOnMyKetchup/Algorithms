using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.Ad_hoc
{
    class ReverseAnInt
    {
        public static int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10; // get the ones digit, the remainder
                x /= 10;  // get rid of the ones/last digit
                //if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                //if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }
            return rev;
        }

        //static void Main(string[] args)
        //{
        //    var result = Reverse(123456);
        //}
    }
}
