using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _518CoinChange
    {
        public static void Main()
        {
            int[] coins = { 1, 2, 5 };
            int amount = 5;

            var results = Change(amount, coins);

            Console.WriteLine(results);
            Console.ReadLine();
        }

        public static int Change(int amount, int[] coins)
        {
            var finalList = new List<IList<int>>();
            ScoreCombinations(finalList, new List<int>(), amount, coins); ;
            return finalList.Count;
        }

        private static void ScoreCombinations(List<IList<int>> finalList, List<int>partialList, int amount, int[] coins)
        {
            if (amount <= 0)
            {
                if (amount == 0)
                {
                    var tempList = new List<int>(partialList);
                    tempList.Sort();


                    finalList.Add(tempList);
                }
                return;
            }

            for (int i = 0; i < coins.Length; i++)
            {
                amount -= coins[i];
                partialList.Add(coins[i]);
                ScoreCombinations(finalList, partialList, amount, coins);
                amount += coins[i];
                partialList.RemoveAt(partialList.Count - 1);
            }

        }
    }
}
