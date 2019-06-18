using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.CTCI
{
    /// <summary>
    /// You have an integer matrix representing a plot of land, where the value at that location
    /// represents the height above sea level.A value of zero indicates water.A pond is a region of
    /// water connected vertically, horizontally, or diagonally. The size of the pond is the total number of
    /// connected water cells.Write a method to compute the sizes of all ponds in the matrix.
    /// </summary>
    class _16_19PondSizes
    {
        int _length = 0;

        List<int> Solve(int[,] pondMatrix)
        {
            _length = pondMatrix.GetLength(0);
            List<int> pondSizeCounts = new List<int>();

            var visitedMatrix = new bool[_length, _length];

            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _length; j++)
                {
                    if (!visitedMatrix[i, j] && pondMatrix[i, j] == 0 && !visitedMatrix[i, j])
                    {
                        pondSizeCounts.Add(BFS(visitedMatrix, pondMatrix, i, j));
                    }
                }
            }

            return pondSizeCounts;
        }

        private static int BFS(bool[,] visited, int[,] pondMatrix, int i, int j)
        {
            int count = 1;
            
            Queue<(int, int)> coordinatesQueue = new Queue<(int, int)>();
            coordinatesQueue.Enqueue((i, j));
            visited[i, j] = true;

            while (coordinatesQueue.Count > 0)
            {
                var current = coordinatesQueue.Dequeue();

                i = current.Item1;
                j = current.Item2;

                // during dequeue phase, add on any 0's that you find
                for (int x = i - 1; x <= i + 1; x++)
                {
                    if (x < 0 || x > pondMatrix.GetLength(0) - 1) continue;

                    for (int y = j - 1; y <= j + 1; y++)
                    {
                        if (y < 0 || y > pondMatrix.GetLength(1) - 1) continue;
                 
                        if (pondMatrix[x, y] == 0 && !visited[x, y])
                        {
                            coordinatesQueue.Enqueue((x, y));
                            visited[x, y] = true;
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        //static void Main()
        //{
        //    // 3 ponds sized 2, 4, and 1.
        //    int[,] pondMatrix = new int[4, 4]
        //        { 
        //            { 0, 2, 1, 0 },
        //            { 0, 1, 0, 1 },
        //            { 1, 1, 0, 1 },
        //            { 0, 1, 0, 1 },
        //        };

        //    _16_19PondSizes pond = new _16_19PondSizes();
        //    var results = pond.Solve(pondMatrix);

        //    foreach (var result in results)
        //    {
        //        Console.WriteLine($"There is a pond of length {result}.");
        //    }

        //    Console.ReadLine();
        //}

    }
}
