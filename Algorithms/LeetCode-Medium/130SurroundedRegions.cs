using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _130SurroundedRegions
    {
        //public static void Main()
        //{
        //    char[][] board = new char[3][]
        //    {
        //        new char[3]{ 'O', 'O', 'O' },
        //        new char[3]{ 'O', 'O', 'O' },
        //        new char[3]{ 'O', 'O', 'O' }
        //    };

        //    Solve(board);

        //    //Console.WriteLine();
        //    Console.ReadLine();
        //}

        public static void Solve(char[][] board)
        {
            if (board.Length == 0) return;

            Queue<(int r, int c)> queue = new Queue<(int r, int c)>();

            int w = board[0].Length - 1;
            int l = board.Length - 1;

            for (int r = 0; r < l; r++)
            {
                if (board[r][0] == 'O') BFS(board, queue, r, 0);
                if (board[r][w] == 'O') BFS(board, queue, r, w);
            }

            for (int c = 0; c < w; c++)
            {
                if (board[0][c] == 'O') BFS(board, queue, 0, c);
                if (board[l][c] == 'O') BFS(board, queue, l, c);
            }

            for (int i = 1; i < l; i++)
            {
                for (int j = 1; j < w; j++)
                {
                    if (board[i][j] == 'O') board[i][j] = 'X';
                }
            }

            for (int i = 0; i <= l; i++)
            {
                for (int j = 0; j <= w; j++)
                {
                    if (board[i][j] == 'S') board[i][j] = 'O';
                }
            }

            var test = board;
        }

        private static void BFS(char[][] board, Queue<(int r, int c)> queue, int r, int c)
        {
            queue.Enqueue((r, c));

            while (queue.Count != 0)
            {
                var (cr, cc) = queue.Dequeue();

                if (cr < 0 || cc < 0 || cr >= board.Length || cc >= board[0].Length || board[cr][cc] != 'O')
                    continue;

                board[cr][cc] = 'S';

                queue.Enqueue((cr - 1, cc));
                queue.Enqueue((cr + 1, cc));
                queue.Enqueue((cr, cc - 1));
                queue.Enqueue((cr, cc + 1));
            }
        }
    }
}
