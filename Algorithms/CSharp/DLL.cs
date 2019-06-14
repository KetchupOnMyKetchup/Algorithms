using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CSharp
{
    /// <summary>
    /// https://www.youtube.com/watch?v=uz6dimvl40Q
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DLL<T>
    {
        private class DLNode
        {
            public T Data { get; set; }
            public DLNode Next { get; set; }
            public DLNode Prev { get; set; }

            public DLNode(T data)
            {
                Data = data;
            }
        }

        DLNode _head;

        public DLL()
        {
                
        }

        public DLL(IEnumerable<T> seedItems)
        {
            //foreach (var item in seedItems)
            //{
            //    DLNode node = new DLNode(item);
            //    //
            //}
        }

        // 1 2 3 4 5
        public void Reverse()
        {
            DLNode temp = null;
            DLNode current = _head;

            while (current != null)
            {
                temp = current.Prev; // hold this var

                current.Prev = current.Next; // swap next and prev
                current.Next = temp; // swap next and prev

                current = current.Prev; // increment. current prev is the actual "next"
            }

            /* Before changing head, check for 
             the cases like empty list and 
            list with only one node */
            if (temp != null)
            {
                // temp = 4
                // temp.Prev = 5
                _head = temp.Prev;
            }

        }
    }
}
