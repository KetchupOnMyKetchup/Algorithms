using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithms.Review
{
    class ByteReaderKMP
    {
        public void Main()
        {

        }

        // Given a byte array stream from a path, find out if a byte[] is found in it, true or false
        public bool FindBytesInFile(string path, byte[] pattern)
        {
            int index = 0;
            byte current;

            int[] lps = calculateLPS(pattern);

            using (BinaryReader br = new BinaryReader(File.OpenRead(path)))
            {
                Stream bs = br.BaseStream;
                while (bs.Position < bs.Length)
                {
                    current = br.ReadByte();
                    if (current == pattern[index])
                    {
                        index++;
                        if (index == pattern.Length) return true;
                    }
                    else
                    {
                        while (index > 0)
                        {
                            index = lps[index - 1];
                            if (current == pattern[index])
                            {
                                index++;
                                break;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private int[] calculateLPS(byte[] pattern)
        {
            int[] lps = new int[pattern.Length];

            for (int i = 1; i < pattern.Length; i++)
            {
                int l = lps[i-1];

                if (pattern[l] == pattern[i])
                {
                    lps[i] = l + 1;
                }
            }

            return lps;
        }
    }
}
