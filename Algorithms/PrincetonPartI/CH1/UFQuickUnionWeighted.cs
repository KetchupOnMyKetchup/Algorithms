using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI
{
    /// <summary>
    /// Keep track of tree size and take steps to avoid having tall trees.
    /// Smaller tree will connect to the root of the larger tree.
    /// Java implementaion on p. 228
    /// Depth of any node x is at most lg N (lg = base-2 logarithms)
    /// If N is 1,000 its 10 (2^10 = 1000)
    /// If N is 1,000,000 its 20 (2^20)
    /// If N is 1,000,000,000 its 30 (2^30)
    /// Can also add path conpression: just after computing root of p, 
    /// set the id of each examined node to point to that root
    /// Memory analysis: total of 8n + 88 bytes = ~8n bytes 
    /// </summary>
    public class QuickUnionUF2 // Weighted Quick Union, 16 bytes object overhead
    {
        private int[] id; // 4n + 24 memory
        private int[] sz; // 4n + 24 memory
        private int count; // number of components. 4 bytes for int
        // 4 bytes padding

        public QuickUnionUF2(int N)
        {
            id = new int[N];
            for (int i = 0; i < N; i++) id[i] = i;

            sz = new int[N];
            for (int i = 0; i < N; i++) sz[i] = 1;
        }

        public int Count() { return count;  }

        private int Root(int i)
        {
            // Chase parent ID until reach the root (depth of i array accesses)
            while (i != id[i])
            {
                // Halves path length. No reason not to, keeps tree almost completely flat.
                id[i] = id[id[i]]; // Only 1 extra line of code to do path compression improvement! 
                
                i = id[i];
            }
            return i;
        }

        public bool Connected(int p, int q) // Find
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);

            if (i == j) return;

            // Make smaller root point to the larger root.
            if (sz[i] < sz[j]) // if i is smaller than j
            {
                id[i] = j; // point i to new root j
                sz[j] += sz[i]; // add the count of the smaller array to the count of the larger array
            }
            else // if j is smaller than i
            {
                id[j] = i;
                sz[i] += sz[j];
            }

            count--; // if we combine components, the count of components goes down by 1
        }
    }
}
