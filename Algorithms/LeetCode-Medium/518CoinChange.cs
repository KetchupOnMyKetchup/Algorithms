using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _518CoinChange
    {
        //public static void Main()
        //{
        //    int[] coins = { 1, 2, 5 };
        //    int amount = 5;

        //    var results = Change(amount, coins);

        //    Console.WriteLine(results);
        //    Console.ReadLine();
        //}

        // https://www.youtube.com/watch?time_continue=1&v=jaNZ83Q3QGc
        public static int Change(int amount, int[] coins)
        {
            int[] dp = new int[amount + 1];
            dp[0] = 1;

            foreach (var coin in coins)
            {
                for (int i = 1; i <= amount; i++)
                {
                    if (i - coin >= 0)
                    {
                        dp[i] += dp[i - coin];
                    }
                }
            }

            return dp[amount];
        }
    }
}
