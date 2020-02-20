using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.Ad_hoc
{
    class Add2LL
    {
        //static void Main(string[] args)
        //{
        //    Node l1 = new Node(1);
        //    l1.Next = new Node(2);
        //    l1.Next.Next = new Node(3);

        //    Node l2 = new Node(2);
        //    l2.Next = new Node(3);
        //    l2.Next.Next = new Node(4);

        //    Console.WriteLine(MergeSumLL(l1, l2));
        //    Console.ReadLine();
        //}

        class Node
        {
            public Node(int value) { Value = value; }
            public Node Next;
            public int Value;
        }

        private static Node MergeSumLL(Node l1, Node l2)
        {
            // O(n) time required, no space requirements

            // create new LL and iterate through both and add

            // to save space, iterate through both and just add value to first LL

            Node dummy = new Node(0);
            dummy.Next = l1;

            while (l1 != null && l2 != null)
            {
                l1.Value += l2.Value;

                l1 = l1.Next;
                l2 = l2.Next;
            }

            return dummy.Next;
        }
    }
}
