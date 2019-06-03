using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH4
{
    /// <summary>
    /// tldr: Flexible and extendable 
    /// 
    /// If Q > M*N^2, the probabtility of a false collision is 1/N
    /// If you max out Q to largest long possible, then collision chance decreases. Calculated by 1/Q
    /// 
    /// Monte Carlo version = if hash matches, return it. Don't double check. 
    /// Always linear time. Extremely likely to get right answer (but not always)
    /// 
    /// Las Vegas version = if hash matches, make sure that the actual numbers match. Always returns correct answer. 
    /// Extrenely likely to run in linear time (but worst case is M*N)
    /// </summary>
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
            Q = 997; // TODO: Fix to generate random prime larger than M*N^2
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
