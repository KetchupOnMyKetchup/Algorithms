using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartII.CH4
{
    public class TrieST<Value>
    {
        private static readonly int R = 256;
        private Node root = new Node();

        private class Node
        {
            public Object value;
            public Node[] next = new Node[R];
        }

        public void put(String key, Value val)
        {
            root = put(root, key, val, 0);
        }

        private Node put(Node x, String key, Value val, int d)
        {
            if (x == null) x = new Node();

            if (d == key.Length) { x.value = val; return x; }
            char c = key[d];
            x.next[c] = put(x.next[c], key, val, d + 1);

            return x;
        }

        public bool contains(String key)
        {
            return get(key) != null;
        }

        public Value get(String key)
        {
            Node x = get(root, key, 0);
            if (x == null) return default(Value);
            return (Value)x.value;
        }

        private Node get(Node x, String key, int d)
        {
            if (x == null) return null;
            if (d == key.Length) return x;
            char c = key[d];
            return get(x.next[c], key, d + 1);
        }
    }
}