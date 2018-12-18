using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public class Node
    {
        public Node next { get; set; }

        public Object data { get; set; }

        public Node()
        {

        }

        public Node(int value)
        {
            data = value;
        }
    }
}

