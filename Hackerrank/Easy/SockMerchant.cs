using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank.Easy
{
    public class SockMerchant
    {
        // https://www.hackerrank.com/challenges/sock-merchant/problem
        static int SockMerchant_method(int numberSocks, int[] arrayOfSocks)
        {
            int numberSockPairs = 0;

            HashSet<int> hash = new HashSet<int>();

            foreach (int sock in arrayOfSocks)
            {
                bool isSockAdded = hash.Add(sock);

                if (!isSockAdded)
                {
                    hash.Remove(sock);
                    numberSockPairs++;
                }
            }

            return numberSockPairs;
        }

        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] ar = Array.ConvertAll(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), arTemp => Convert.ToInt32(arTemp));
        //    int result = sockMerchant(n, ar);
        //}
    }
}
