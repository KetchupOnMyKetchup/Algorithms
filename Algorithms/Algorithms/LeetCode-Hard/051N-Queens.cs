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

            AddQueens(n, chessBoard, new List<string>(), prevQueens, 0);

            return chessBoard;
        }

        private static void AddQueens(int n, List<IList<string>> chessBoard, List<string> partialSolution, int[] prevQueens, int y)
        {
            if (y == n)
            {
                chessBoard.Add(new List<string>(partialSolution));
                // remove partial Sol'n, make state be prevQueens. convert prevQueens to List<string> to return it
                return;
            } 

            StringBuilder values = new StringBuilder();

            for (int i = 0; i < n; i++) values.Append(".");

            for (int i = 0; i < n; i++)
            {
                if (!IsPossiblePlacement(y, prevQueens, i)) continue;

                values[i] = 'Q';
                prevQueens[y] = i;

                partialSolution.Add(values.ToString());

                AddQueens(n, chessBoard, partialSolution, prevQueens, y + 1);
                prevQueens[y] = -1;
                values[i] = '.';
                partialSolution.RemoveAt(partialSolution.Count - 1);

                // at end i hits 4, no solutions found, and returns and exits code
            }

        }

        private static bool IsPossiblePlacement(int currY, int[] prevQueens, int currX)
        {
            int prevY = 0;

            foreach (var prevQueenX in prevQueens)
            {
                if (prevQueenX == -1) return true;
                if (prevQueenX == currX) return false;
                
                if (Math.Abs(prevY - currY) == Math.Abs(prevQueenX - currX)) return false;

                prevY++;
            }

            return true;
        }
    }
}
