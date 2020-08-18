using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithms.Review
{
    class ByteReaderBruteForce
    {
        public void Main()
        {

        }

        // Given a byte array stream from a path, find out if a byte[] is found in it, true or false
        public bool FindBytesInFile(string path, byte[] pattern)
        {
            int patternIndex = 0;
            byte current;

            using (BinaryReader br = new BinaryReader(File.OpenRead(path)))
            {
                Stream bs = br.BaseStream;
                while (bs.Position < bs.Length)
                {
                    current = br.ReadByte();
                    if (current == pattern[patternIndex])
                    {
                        patternIndex++;
                        if (patternIndex == pattern.Length) return true;
                    }
                    else
                    {
                        if (patternIndex > 0)
                            patternIndex = LookBack(patternIndex, pattern, current);
                    }
                }
            }

            return false;
        }

        private int LookBack(int length, byte[] pattern, byte current)
        {
            byte[] ruler = new byte[length];
            for (int i = 0; i < length - 1; i++)
                ruler[i] = pattern[i + 1];
            ruler[length - 1] = current;

            int start = 0;
            int rulerIndex = 0;
            int pattIndex = 0;

            while (rulerIndex < length)
            {
                if (ruler[rulerIndex] == pattern[pattIndex])
                {
                    rulerIndex++;
                    pattIndex++;
                }
                else
                {
                    start++;
                    rulerIndex = start;
                    pattIndex = 0;
                }
            }

            return pattIndex;
        }
    }
}
