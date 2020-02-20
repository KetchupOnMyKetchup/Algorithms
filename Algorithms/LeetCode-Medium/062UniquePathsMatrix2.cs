using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _062UniquePathsMatrix2
    {
        //public static void Main()
        //{
        //    int result = UniquePaths2(3, 2);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        private static int UniquePaths2(int m, int n)
        {
            int[,] dp = new int[m, n];
            
            for (int i = 0; i < m; i++) dp[i, 0] = 1;
            for (int j = 0; j < n; j++) dp[0, j] = 1;

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[m - 1, n - 1];
        }
    }
}
