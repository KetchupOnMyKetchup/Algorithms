using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Hard
{
    class _037SudokuSolver
    {
        //public static void Main()
        //{
        //    char[][] board = new char[9][]
        //    {
        //        new char[] { '5','3','.','.','7','.','.','.','.' },
        //        new char[] { '6','.','.','1','9','5','.','.','.' },
        //        new char[] { '.','9','8','.','.','.','.','6','.' },
        //        new char[] { '8','.','.','.','6','.','.','.','3' },
        //        new char[] { '4','.','.','8','.','3','.','.','1' },
        //        new char[] { '7','.','.','.','2','.','.','.','6' },
        //        new char[] { '.','6','.','.','.','.','2','8','.' },
        //        new char[] { '.','.','.','4','1','9','.','.','5' },
        //        new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        //    };

        //    SolveSudoku(board);
        //    Console.ReadLine();
        //}

        public static void SolveSudoku(char[][] board)
        {
            CanSolveSudokuFromCell(0, 0, board);
        }

        private static char EMPTY_ENTRY = '.';

        public static bool CanSolveSudokuFromCell(int row, int col, char[][] board)
        {
            // first figure out policies of when to stop
            // out of bounds end of row
            if (col == board[row].Length)
            {
                col = 0;
                row++;

                if (row == board.Length) return true;
            }

            // no need to solve a cell if it already has a value
            if (board[row][col] != EMPTY_ENTRY) return CanSolveSudokuFromCell(row, col + 1, board);

            // Solve
            for (int val = 1; val <= 9; val++)
            {
                char c = (char)(val + '0');

                // choose, recurse, unchoose
                if (CanPlaceValue(board, row, col, c))
                {
                    board[row][col] = c;
                    if (CanSolveSudokuFromCell(row, col + 1, board)) return true;
                    board[row][col] = EMPTY_ENTRY;
                }
            }

            return false;
        }

        static readonly int[][] listSubBoxes = new int[3][]
        {
            new int[] { 0, 2 },
            new int[] { 3, 5 },
            new int[] { 6, 8 }
        };

        private static bool CanPlaceValue(char[][] board, int row, int col, char c)
        {
            // check row
            for (int i = 0; i <= 8; i++)
            {
                if (board[i][col] == c) return false;
            }

            // check column
            for (int i = 0; i <= 8; i++)
            {
                if (board[row][i] == c) return false;
            }

            // check sub-box
            int[] rowSubBox = new int[1];
            int[] colSubBox = new int[1];

            foreach (var subBox in listSubBoxes)
            {
                if (row >= subBox[0] && row <= subBox[1]) rowSubBox = subBox;
            }

            foreach (var subBox in listSubBoxes)
            {
                if (col >= subBox[0] && col <= subBox[1]) colSubBox = subBox;
            }

            for (int i = colSubBox[0]; i <= colSubBox[1]; i++)
            {
                for (int j = rowSubBox[0]; j <= rowSubBox[1]; j++)
                {
                    if (board[j][i] == c) return false;
                }
            }

            return true;
        }

        // Java B2B solution

        
    }
}
