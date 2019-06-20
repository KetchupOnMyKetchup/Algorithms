using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.Ad_hoc
{
    class MaxProfit
    {
        public static int SolveMaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                    minPrice = prices[i];
                else
                {
                    var profit = prices[i] - minPrice;
                    if (profit > maxProfit)
                        maxProfit = profit;
                }
            }

            return maxProfit;
        }

        static void Main()
        {
            SolveMaxProfit(new[] { 7, 1, 5, 3, 6, 4 });
        }
    }
}
