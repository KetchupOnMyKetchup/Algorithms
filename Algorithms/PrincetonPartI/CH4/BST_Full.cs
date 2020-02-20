using System;

namespace Algorithms.Algorithms.PrincetonPartI.CH4
{
    /// <summary>
    /// If N is random, search/insert is 2 ln N
    /// Worst case is when N is already sorted
    /// Expected height of tree (random) is 4.3 ln N
    /// </summary>
    public class BST_Full<TKey, TValue> where TKey : IComparable<TKey>
    {
        private Node<TKey, TValue> root;
        public int Size()
        {
            return Size(root);
        }

        private int Size(Node<TKey, TValue> x)
        {
            if (x == null) return 0;
            else return x.Size;
        }

        public TValue Get(Node<TKey, TValue> x, TKey key)
        {
            // Return value associated with key in the subtree rooted at x;
            // return null if key not present in subtree rooted at x.
            if (x == null) return default(TValue);
            int cmp = key.CompareTo(x.Key);
            if (cmp < 0) return Get(x.Left, key);
            else if (cmp > 0) return Get(x.Right, key);
            else return x.Val;
        }

        public void Put(TKey key, TValue val)
        {
            // Search for key. Update value if found; grow table if new.
            root = Put(root, key, val);
        }

        private Node<TKey, TValue> Put(Node<TKey, TValue> x, TKey key, TValue val)
        {
            // Change key’s value to val if key in subtree rooted at x.
            // Otherwise, add new node to subtree associating key with val.
            if (x == null) return new Node<TKey, TValue>(key, val, 1);

            int cmp = key.CompareTo(x.Key);

            if (cmp < 0) x.Left = Put(x.Left, key, val);
            else if (cmp > 0) x.Right = Put(x.Right, key, val);
            else x.Val = val;

            x.Size = Size(x.Left) + Size(x.Right) + 1;

            return x;
        }

        public TKey min()
        {
            return min(root).Key;
        }
        private Node<TKey, TValue> min(Node<TKey, TValue> x)
        {
            if (x.Left == null) return x;
            return min(x.Left);
        }
        public TKey floor(TKey key)
        {
            Node<TKey, TValue> x = floor(root, key);
            if (x == null) return default(TKey);
            return x.Key;
        }
        private Node<TKey, TValue> floor(Node<TKey, TValue> x, TKey key)
        {
            if (x == null) return null;
            int cmp = key.CompareTo(x.Key);
            if (cmp == 0) return x;
            if (cmp < 0) return floor(x.Left, key);
            Node<TKey, TValue> t = floor(x.Right, key);
            if (t != null) return t;
            else return x;
        }
    }

    public class Node<TKey, TValue>
    {
        public TKey Key { get; set; }

        public TValue Val { get; set; }

        public Node<TKey, TValue> Left { get; set; }

        public Node<TKey, TValue> Right { get; set; }

        /// <summary>
        /// # nodes in subtree rooted here
        /// </summary>
        public int Size { get; set; }

        public Node(TKey key, TValue val, int n)
        {
            Key = key;
            Val = val;
            Size = n;
        }
    }
}