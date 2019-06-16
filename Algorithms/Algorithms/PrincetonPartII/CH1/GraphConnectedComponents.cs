using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH4
{
    /// <summary>
    /// Like Union Find, but finds max number of connected components.
    /// </summary>
    public class GraphConnectedComponents
    {
        private bool[] _hasBeenVisited; // marked
        
        // If a bunch of vertices say 0, they are all connected. if another set say 1, those are connected to each other... etc. 
        private int[] _connectedVertexIdGroup; // "id" in Princeton course. Id of component containing V
        private int _count; // # of components

        public GraphConnectedComponents(Graph_Adjacency_List G)
        {
            _hasBeenVisited = new bool[G.numberVertices];
            _connectedVertexIdGroup = new int[G.numberVertices];
            for (int v = 0; v < G.numberVertices; v++)
            {
                if (!_hasBeenVisited[v])
                {
                    DepthFirstSearch(G, v);
                    _count++;
                }
            }
        }
        public int GetCount()
        {
            return _count;
        }

        public int GetId(int v)
        {
            return _connectedVertexIdGroup[v];
        }

        private void DepthFirstSearch(Graph_Adjacency_List G, int vertex)
        {
            _hasBeenVisited[vertex] = true;
            _connectedVertexIdGroup[vertex] = _count;
            foreach (var adjacentVertex in G.FindAdjacentVertices(vertex))
            {
                if (!_hasBeenVisited[adjacentVertex])
                {
                    DepthFirstSearch(G, adjacentVertex);
                }
            }
        }
    }
}
