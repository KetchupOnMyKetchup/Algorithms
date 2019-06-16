using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.CTCI
{
    /// <summary>
    /// Write a function to swap a number in place (that is, without temporary variables).
    /// Hint: Try picturing the two numbers, a and b, on a number line.
    /// Hint: Let diff be the difference between a and b. Can you use diff in some way? Then can you get rid of this temporary variable?
    /// Hint: You could also try using XOR.
    /// </summary>
    class _16_1NumberSwap
    {
        public static void SwapNumbers(int a, int b) // 10 and 2
        {
            Console.WriteLine($"Pre-Swap: The value of a is {a} and b is {b}");

            // 8 = 10 - 2
            a = a - b;

            // 10 = 8 + 2
            b = a + b;

            // 2 = 10 - 8
            a = b - a;

            Console.WriteLine($"Post-Swap: The value of a is {a} and b is {b}");
            Console.Read();
        }

        //static void Main(string[] args)
        //{
        //    _16_1NumberSwap.SwapNumbers(10, 2);
        //}
    }
}
