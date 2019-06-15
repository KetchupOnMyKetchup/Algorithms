using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH4
{
    /// <summary>
    /// In array 0, list all things that 0 is connected to.. and so on.
    /// If 0 is connected to 5, then there will be a 0--5 and 5--0 connection (2 representations of same edge)
    /// See page 23 of 41 PDF on Graphs (Algortihms 2 course)
    /// </summary>
    class Graph_Adjacency_List
    {
        ConcurrentBag<int>[] graph;

        /// <summary>
        /// Create an array of concurrent bags
        /// </summary>
        /// <param name="V">Number of Vertices</param>
        public Graph_Adjacency_List(int V)
        {
            graph = new ConcurrentBag<int>[V];

            for (int v = 0; v < V; v++)
            {
                graph[v] = new ConcurrentBag<int>();
            }
        }
        public void addEdge(int v, int w)
        {
            graph[v].Add(w);
            graph[w].Add(v);
        }
        public IEnumerable<int> adj(int v)
        {
            return graph[v];
        }
    }
}
