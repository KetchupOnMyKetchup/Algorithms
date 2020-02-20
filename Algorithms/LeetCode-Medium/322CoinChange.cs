using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _322CoinChange
    {
        //public static void Main()
        //{
        //    int[] coins = new int[] { 1, 2, 5 };
        //    var result = CoinChange(coins, 11);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        public static int CoinChange(int[] coins, int amount)
        {
            if (amount < 1) return 0;

            return Helper(coins, amount, new int[amount]);
        }

        private static int Helper(int[] coins, int remainder, int[] dp)
        {
            if (remainder < 0) 
                return -1; // invalid solution
            if (remainder == 0) 
                return 0; // valid solution
            if (dp[remainder - 1] != 0)
                return dp[remainder - 1]; // already completed, re-use

            int min = int.MaxValue;

            foreach (var coin in coins)
            {
                int res = Helper(coins, remainder - coin, dp);

                if (res >= 0 && res < min) // only save valid solutions as min
                {
                    min = res + 1; // +1 to add 1 coin that we're testing out
                }
            }

            dp[remainder - 1] = (min == int.MaxValue) ? -1 : min;
            return dp[remainder - 1];
        }
    }
}
