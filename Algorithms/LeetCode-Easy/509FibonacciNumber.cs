using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _509FibonacciNumber
    {
        //static void Main()
        //{
        //    var result = Fib(5);
        //    Console.WriteLine(result);
        //}

        public static int Fib(int N)
        {
            if (N <= 1) return N; // missed this part
            
            int[] dp = new int[N + 2];

            dp[0] = 0;
            dp[1] = 1;

            if (dp[N] != 0) return dp[N];

            dp[N] = Fib(N - 1) + Fib(N - 2);

            return dp[N];
        }

        //public static int Fib(int N)
        //{
        //    if (N == 0) return 0;
        //    if (N == 1 || N == 2) return 1;

        //    return Fib(N - 1) + Fib(N - 2);
        //}
    }
}
