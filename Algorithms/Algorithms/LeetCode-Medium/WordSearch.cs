using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    /// <summary>
    /// The word can be constructed from letters of sequentially adjacent cell, 
    /// where "adjacent" cells are those horizontally or vertically neighboring. 
    /// The same letter cell may not be used more than once.
    /// </summary>
    class WordSearch
    {
        static void Main()
        {
            char[][] board = new char[3][]
            {
                new char[] { 'A','B','C','E' },
                new char[] { 'S','F','C','S' },
                new char[] { 'A','D','E','E' }
            };

            var result = Exist(board, "ABC");
            Console.WriteLine(result);
        }

        int[][] dir = new int[4][]
        {
            new int[] {-1, 0},
            new int[] {1, 0},
            new int[] {-1, 0},
            new int[] {-1, 0}
        }; // use with for loop

        private static bool Helper(int i, int j, char[][] board, string word, int charIndex)
        {
            // Space complexity is O(word.Length) because that's how far deep it can recurse
            if (word.Length == charIndex) return true; 

            char temp = board[i][j];

            // up
            if (i > 0 && board[i - 1][j] == word[charIndex])
            {
                board[i][j] = '0';
                if (Helper(i - 1, j, board, word, charIndex + 1)) return true;
                board[i][j] = temp;
            }

            // down
            if (i < board.Length - 1 && board[i + 1][j] == word[charIndex])
            {
                board[i][j] = '0';
                if (Helper(i + 1, j, board, word, charIndex + 1)) return true;
                board[i][j] = temp;
            }

            // left
            if (j > 0 && board[i][j - 1] == word[charIndex])
            {
                board[i][j] = '0';
                if (Helper(i, j - 1, board, word, charIndex + 1)) return true;
                board[i][j] = temp;
            }

            // right
            if (j < board[0].Length - 1 && board[i][j + 1] == word[charIndex])
            {
                board[i][j] = '0';
                if (Helper(i, j + 1, board, word, charIndex + 1)) return true;
                board[i][j] = temp;
            }

            return false;
        }

        public static bool Exist(char[][] board, string word)
        {
            // Time compelxity is M x N
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        if (Helper(i, j, board, word, 1)) return true;
                    }
                }
            }

            return false;
        }
    }
}
