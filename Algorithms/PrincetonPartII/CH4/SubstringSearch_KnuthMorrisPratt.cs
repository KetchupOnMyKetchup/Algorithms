using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH4
{
    /// <summary>
    /// Really complicated
    /// Can display in Graphical and Table form
    /// </summary>
    public class KMP
    {
        private String pat;
        private int[][] dfa;
        public KMP(String pat)
        { 
            // Build DFA from pattern.
            this.pat = pat;
            int M = pat.Length;
            int R = 256;
            dfa = new int[R][];

            dfa[pat[0]][0] = 1;

            for (int X = 0, j = 1; j < M; j++)
            { // Compute dfa[][j].
                for (int c = 0; c < R; c++)
                    dfa[c][j] = dfa[c][X]; // Copy mismatch cases.
                dfa[pat[j]][j] = j + 1; // Set match case.
                X = dfa[pat[j]][X]; // Update restart state.
            }
        }
        public int search(String txt)
        { // Simulate operation of DFA on txt.
            int i, j, N = txt.Length, M = pat.Length;
            for (i = 0, j = 0; i < N && j < M; i++)
                j = dfa[txt[i]][j];
            if (j == M) return i - M; // found (hit end of pattern)
            else return N; // not found (hit end of text)
        }

    }
}
