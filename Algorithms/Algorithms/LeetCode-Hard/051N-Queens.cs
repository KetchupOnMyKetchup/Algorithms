using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Hard
{
    class _051N_Queens
    {
        public static void Main()
        {
            int n = 4;

            var result = SolveNQueens(n);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static IList<IList<string>> SolveNQueens(int n)
        {
            List<IList<string>> chessBoard = new List<IList<string>>();

            int[] prevQueens = new int[n];
            for (int i = 0; i < n; i++) prevQueens[i] = -1;

            AddQueens(n, chessBoard, prevQueens, 0);

            return chessBoard;
        }

        private static void AddQueens(int n, List<IList<string>> chessBoard, int[] prevQueens, int y)
        {
            if (y == n)
            {
                List<string> temp = new List<string>();
                
                foreach (var prevQueen in prevQueens)
                {
                    StringBuilder values = new StringBuilder();
                    for (int i = 0; i < n; i++) values.Append(".");
                    values[prevQueen] = 'Q';
                    temp.Add(values.ToString());
                }
                
                chessBoard.Add(temp);
                return;
            } 

            for (int i = 0; i < n; i++)
            {
                if (!IsPossiblePlacement(y, prevQueens, i)) continue;
                prevQueens[y] = i;
                AddQueens(n, chessBoard, prevQueens, y + 1);
                prevQueens[y] = -1;
            }

        }

        private static bool IsPossiblePlacement(int currY, int[] prevQueens, int currX)
        {
            int prevY = 0;

            foreach (var prevQueenX in prevQueens)
            {
                if (prevQueenX == -1) return true;
                if (prevQueenX == currX || Math.Abs(prevY - currY) == Math.Abs(prevQueenX - currX)) return false;
                prevY++;
            }

            return true;
        }
    }
}
