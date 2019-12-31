using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _121BuyAndSellStock
    {
        //public static void Main()
        //{
        //    int[] prices = { 7, 1, 5, 3, 6, 4 };

        //    var results = MaxProfit(prices);

        //    Console.WriteLine(results);
        //    Console.ReadLine();
        //}

        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int[] dp = new int[prices.Length];
            dp[0] = 0;
            int minimum = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > minimum) dp[i] = prices[i] - minimum;
                else
                {
                    dp[i] = 0;
                    if (prices[i] < minimum) minimum = prices[i];
                }
            }

            int max = 0;

            foreach (var value in dp)
            {
                if (value > max) max = value;
            }

            return max;
        }
    }
}
