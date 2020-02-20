using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI
{
    /// <summary>
    /// Initialize: N
    /// Union: N
    /// Find: 1
    /// Accesses: takes N^2 accesses to process sequence of N union commands on N objects
    /// Summary: Union is too expensive. Too slow for huge problems. Quick union will be a little faster. 
    /// </summary>
    public class QuickFindUF
    {
        private int[] id;

        public QuickFindUF(int N)
        {
            id = new int[N];
            for (int i = 0; i < N; i++) id[i] = i;
        }

        public bool Connected(int p, int q) // Find
        {
            return id[p] == id[q];
        }

        public void Union(int p, int q)
        {
            int pid = id[p];
            int qid = id[q];

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == pid) id[i] = qid;
            }
        }
    }
}
