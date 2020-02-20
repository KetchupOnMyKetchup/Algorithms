using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _733FloodFill
    {
        //public static void Main()
        //{
        //    int[][] image = new int[2][] 
        //    { 
        //        new int[3]{ 0, 0, 0 },
        //        new int[3]{ 0, 1, 1 }
        //    };

        //    var result = FloodFill(image, 1, 1, 1);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            Queue<(int r, int c)> queue = new Queue<(int r, int c)>();

            queue.Enqueue((sr, sc));
            int oldColor = image[sr][sc];

            while (queue.Count != 0)
            {
                var (r, c) = queue.Dequeue();

                if (r < 0 || r >= image.Length || c < 0 || c >= image[0].Length || image[r][c] != oldColor || image[r][c] == newColor) 
                    continue;

                image[r][c] = newColor;

                queue.Enqueue((r - 1, c));
                queue.Enqueue((r + 1, c));
                queue.Enqueue((r, c - 1));
                queue.Enqueue((r, c + 1));
            }

            return image;
        }
    }
}
