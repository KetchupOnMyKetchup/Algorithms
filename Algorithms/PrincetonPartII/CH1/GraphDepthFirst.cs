using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH4
{
    /// <summary>
    /// Visit a vertiex v, mark it has been visited.
    /// Recursively mark all unvisited adjacent vertices. 
    /// </summary>
    public class GraphDepthFirst
    {
        private bool[] _hasBeenVisited;
        private int[] edgeTo;
        private int s;

        public GraphDepthFirst(Graph_Adjacency_List G, int s)
        {
            int length = G.numberVertices;

            _hasBeenVisited = new bool[length];
            edgeTo = new int[length];

            DepthFirstSearch(G, s);
        }

        private void DepthFirstSearch(Graph_Adjacency_List G, int vertex)
        {
            _hasBeenVisited[vertex] = true;

            foreach (var adjacentVertex in G.FindAdjacentVertices(vertex))
            {
                if (!_hasBeenVisited[adjacentVertex])
                {
                    DepthFirstSearch(G, adjacentVertex);
                    edgeTo[adjacentVertex] = vertex;
                }
            }
        }

        public bool hasPathTo(int v)
        { return _hasBeenVisited[v]; }

        public IEnumerable<int> pathTo(int v)
        {
            if (!hasPathTo(v)) return null;

            Stack<int> path = new Stack<int>();

            for (int x = v; x != s; x = edgeTo[x])
                path.Push(x);

            path.Push(s);

            return path;
        }
    }
}
