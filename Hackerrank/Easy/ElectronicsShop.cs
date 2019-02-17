using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank.Easy
{
    class ElectronicsShop
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            Array.Sort(keyboards);
            int lengthKeyboards = keyboards.Length;

            Array.Sort(drives);
            int lengthdrives = drives.Length;

            int keyboardPrice = 0;
            int price = 0;
            var listPrices = new List<int>();

            for (int i = lengthKeyboards - 1; i >= 0; i--)
            {
                keyboardPrice = keyboards[i];

                for (int j = lengthdrives - 1; j >= 0; j--)
                {
                    price = keyboardPrice + drives[j];

                    if (price <= b) listPrices.Add(price);
                }
            }

            if (listPrices.Count > 0)
            {
                listPrices.Sort();
                return listPrices.Last();
            }

            return -1;
        }
    }

    //static void Main(string[] args)
    //{
    //    string[] bnm = Console.ReadLine().Split(' ');

    //    int b = Convert.ToInt32(bnm[0]);
    //    int n = Convert.ToInt32(bnm[1]);
    //    int m = Convert.ToInt32(bnm[2]);

    //    int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
    //    int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));

    //    //The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
    //    int moneySpent = getMoneySpent(keyboards, drives, b);
    //}

}
