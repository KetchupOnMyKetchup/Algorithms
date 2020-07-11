using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class LetterTilePossibilities
    {
        //public static void Main()
        //{
        //    numTilePossibilities("AAB");
        //}

        public static int numTilePossibilities(String tiles)
        {
            int[] count = new int[26];
            foreach (var c in tiles.ToCharArray())
            {
                count[c - 'A']++;
            }
            return dfs(count);
        }

        static int dfs(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < 26; i++)
            {
                if (arr[i] == 0) continue;
                sum++;
                arr[i]--;
                sum += dfs(arr);
                arr[i]++;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
