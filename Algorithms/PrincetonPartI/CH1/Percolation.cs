using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH1
{
    public class Percolation
    {
        const byte BLOCKED = 0;
        const byte OPEN = 1;
        const byte FULL = 2;
        byte[,] grid;
        QuickUnionUF2 uf;
        int _n = 0;


        public Percolation(int n)                // create n-by-n grid, with all sites blocked
        {
            grid = new byte[n, n];

            uf = new QuickUnionUF2(n*n);

            _n = n;
        }

        public void open(int row, int col)    // open site (row, col) if it is not open already
        {
            if (isOpen(row, col))
                return;

            grid[row, col] = OPEN;

            // if top column, connect to -1
            if (col == 0) uf.Union(ConvertCoordinateToInt(row, col), -1);

            // if bottom column, connect to -2
            if (col == _n) uf.Union(ConvertCoordinateToInt(row, col), -2);

            // union
            CheckAllSides(row, col, row, col - 1);
            CheckAllSides(row, col, row, col + 1);
            CheckAllSides(row, col, row + 1, col);
            CheckAllSides(row, col, row - 1, col);
        }

        private void CheckAllSides(int row1, int col1, int row2, int col2)
        {
            if (row2 >= 0 && col2 >=0 && row2 <= _n && col2 <= _n && grid[row2, col2] == OPEN)
            {
                uf.Union(ConvertCoordinateToInt(row1, col1), ConvertCoordinateToInt(row2, col2));
            }
        }

        private int ConvertCoordinateToInt(int row, int col)
        {
            return (row * _n) + col;
        }

        public bool isOpen(int row, int col)  // is site (row, col) empty open?
        {
            return grid[row, col] == OPEN;
        }

        public bool isFull(int row, int col)  // is site (row, col) full of water?
        {
            return grid[row, col] == FULL;
        }

        public int numberOfOpenSites()       // number of open sites
        {
            int count = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid.Length; col++)
                {
                    if (isOpen(row, col)) count++;
                }
            }

            return count;
        }

        public bool percolates()              // does the system percolate?
        {
            return uf.Connected(-1, -2);
        }

        //public static void Main(String[] args)   // test client (optional)
        //{
        //    Percolation percolation = new Percolation(3);

        //    // open new site
        //    // check if percolates to bottom
        //}
    }
}
