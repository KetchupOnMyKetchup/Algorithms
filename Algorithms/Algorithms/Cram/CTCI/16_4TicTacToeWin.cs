using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.CTCI
{
    /// <summary>
    /// Design an algorithm to figure out if someone has won a game of tic-tac-toe.
    /// </summary>
    class _16_4TicTacToeWin
    {
        // Check every turn 
        // See direction with 2 in a row, see if there is a 3rd. Recursively check other directions just in case
        static string CheckForWin(string[,] board, int lastMoveX, int lastMoveY)
        {
            if (HasWonRow(board, lastMoveX)) return $"The winner is: {board[lastMoveX, lastMoveY]}!";
            if (HasWonColumn(board, lastMoveY)) return $"The winner is: {board[lastMoveX, lastMoveY]}!";
            if (HasWonDiagonal(board, lastMoveX, lastMoveY)) return $"The winner is: {board[lastMoveX, lastMoveY]}!";

            bool isBoardFull = true; 

            // check if board is full
            foreach (var item in board)
            {
                if (item == null) isBoardFull = false;
            }

            if (isBoardFull) return "No winner. Please play again!";
            else return "No winner yet.";
        }

        private static bool HasWonRow(string[,] board, int lastMoveX)
        {
            if (board[lastMoveX, 0] == board[lastMoveX, 1] && board[lastMoveX, 1] == board[lastMoveX, 2]) return true;
            else return false;
        }

        private static bool HasWonColumn(string[,] board, int lastMoveY)
        {
            if (board[0, lastMoveY] == board[1, lastMoveY] && board[1, lastMoveY] == board[2, lastMoveY]) return true;
            else return false;
        }

        private static bool HasWonDiagonal(string[,] board, int lastMoveX, int lastMoveY)
        {
            if (board[1, 1] != null && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) return true;
            if (board[1, 1] != null && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) return true;
            else return false;
        }

        static void Main(string[] args)
        {
            // 2D Array
            string[,] array = new string[3, 3];
            array[0, 0] = "X";
            Console.WriteLine(_16_4TicTacToeWin.CheckForWin(array, 0, 0));

            array[0, 2] = "X";
            Console.WriteLine(_16_4TicTacToeWin.CheckForWin(array, 0, 2));

            array[1, 2] = "O";
            Console.WriteLine(_16_4TicTacToeWin.CheckForWin(array, 1, 2));

            array[0, 1] = "O";
            Console.WriteLine(_16_4TicTacToeWin.CheckForWin(array, 0, 1));

            array[2, 1] = "O";
            Console.WriteLine(_16_4TicTacToeWin.CheckForWin(array, 2, 1));

            array[1, 1] = "X";
            Console.WriteLine(_16_4TicTacToeWin.CheckForWin(array, 1, 1));

            array[2, 2] = "X";
            Console.WriteLine(_16_4TicTacToeWin.CheckForWin(array, 2, 2));
            Console.ReadLine();
        }
    }
}
