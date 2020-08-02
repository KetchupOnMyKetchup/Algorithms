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
            int index = 0;
            byte current;

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
                        if (index > 0)
                            index = LookBack(index, pattern, current);
                    }
                }
            }

            return false;
        }

        private int LookBack(int length, byte[] pattern, byte current)
        {
            byte[] file = new byte[length];
            for (int i = 0; i < length; i++)
                file[i] = pattern[i + 1];
            file[length - 1] = current;

            int start = 0;
            int fileIndex = start;
            int pattIndex = 0;

            while (fileIndex < length)
            {
                if (file[fileIndex] == pattern[pattIndex])
                {
                    fileIndex++;
                    pattIndex++;
                }
                else
                {
                    start++;
                    fileIndex = start;
                    pattIndex = 0;
                }
            }

            return pattIndex;
        }
    }
}
