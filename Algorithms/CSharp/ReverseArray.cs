using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CSharp
{
    public class ReverseArray<T>
    {
        // Regular
        //public int[] Reverse(int[] array)
        //{
        //    int length = array.Length;
        //    int index = length - 1;

        //    for (int i = 0; i < length / 2; i++)
        //    {
        //        var temp = array[i];
        //        array[i] = array[index - i];
        //        array[index - i] = temp;
        //    }

        //    return array;
        //}


        // Generic
        public T[] Reverse(T[] array)
        {
            int length = array.Length;
            int index = length - 1;

            for (int i = 0; i < length / 2; i++)
            {
                var temp = array[i];
                array[i] = array[index - i];
                array[index - i] = temp;
            }

            return array;
        }
    }
}
