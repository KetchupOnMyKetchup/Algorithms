using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _070ClimbStairs
    {
        //static void Main()
        //{
        //    var result = ClimbStairs(10);
        //    Console.WriteLine(result);
        //}

        // DP
        // https://www.youtube.com/watch?v=CFQk7OQO_xM 0:50 - 1:53
        public static int ClimbStairs(int n)
        {
            if (n == 1) return 1;

            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                // The expression is actually the expression for Fibonacci numbers
                dp[i] = dp[i - 2] + dp[i - 1];
            }

            return dp[n];
        }
    }
}
