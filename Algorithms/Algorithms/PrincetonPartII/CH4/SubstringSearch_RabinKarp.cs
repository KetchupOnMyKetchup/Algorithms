using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH4
{
    public class RabinKarp
    {
        private long patHash; // pattern hash value
        private int M; // pattern length
        private long Q; // modulus
        private int R; // radix
        private long RM; // R^(M-1) % Q

        public RabinKarp(string pat)
        {
            M = pat.Length;
            R = 256;
            Q = 997;
            RM = 1;
            for (int i = 1; i <= M - 1; i++)
                RM = (R * RM) % Q;
            patHash = hash(pat, M);
        }
        private long hash(string key, int M)
        {
            long h = 0;

            for (int j = 0; j < M; j++)
                h = (R * h + key[j]) % Q;

            return h;
        }
        public int search(string txt)
        {
            int N = txt.Length;
            int txtHash = (int)hash(txt, M);

            if (patHash == txtHash) return 0;

            for (int i = M; i < N; i++)
            {
                txtHash = (int)((txtHash + Q - RM * txt[i - M] % Q) % Q);
                txtHash = (int)((txtHash * R + txt[i]) % Q);
                if (patHash == txtHash) return i - M + 1;
            }

            return N;
        }
    }
}
