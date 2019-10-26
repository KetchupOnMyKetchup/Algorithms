using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms.HackerrankEasy
{
    class PDFViewer
    {
        // Complete the designerPdfViewer function below.
        static int designerPdfViewer(int[] h, string word)
        {
            List<int> sizes = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                var test = h[word[i] - 'a'];
                sizes.Add(test);
            }

            return sizes.Max() * word.Length;
        }

        //static void Main()
        //{
        //    designerPdfViewer(new int[] { 1, 2, 3, 4 }, "abb");
        //}
    }
}
