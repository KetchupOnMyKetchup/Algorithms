using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.CSharp
{
    class LINQEnumerable
    {
        static void Use()
        {
            var integers = Enumerable.Repeat(1, 10); // 1 1 1 1 1 1 1 1 1 1

            var integers2 = Enumerable.Range(5, 3); // 5 6 7

            // Enumerable.Empty helps when you want to call a method that receives an 
            // IEnumerable collection. In some calling locations, you could pass a query expression. 
            // In others, you could simply pass Enumerable.Empty.
            var empty = Enumerable.Empty<int>();
            Console.WriteLine(empty.Count());
            int[] array = empty.ToArray();
            Console.WriteLine(array.Length);
        }
    }
}
