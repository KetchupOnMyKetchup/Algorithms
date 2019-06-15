using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH4
{
    public class GraphBreadthFirst
    {
        private bool[] marked;
        private int[] edgeTo;

        private void BreadthFirstSearch(Graph_Adjacency_List G, int s)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(s);
            marked[s] = true;

            while (queue.Count > 0)
            {
                int v = queue.Dequeue();

                foreach (var w in G.FindAdjacentVertices(v))
                {
                    if (!marked[w])
                    {
                        queue.Enqueue(w);
                        marked[w] = true;
                        edgeTo[w] = v;
                    }
                }
            }
        }
    }
}
