using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH6
{
    /// <summary>
    /// 
    /// </summary>
    public class SeparateChainingHashST<Key, Value> // ST = Symbol Table
    {
        private class Node
        {
            public Node(object key, object val, Node next)
            {
                this.key = key;
                this.val = val;
                this.next = next;
            }

            private Object key;
            private Object val;
            private Node next;
        }

        private int M = 97; // number of chains
        private Node[] st = new Node[M]; // array of chains

        private int hash(Key key)
        { return (key.hashCode() & 0x7fffffff) % M; }

        public Value get(Key key)
        {
            int i = hash(key);
            for (Node x = st[i]; x != null; x = x.next)
                if (key.equals(x.key)) return (Value)x.val;
            return null;
        }
    }
}
