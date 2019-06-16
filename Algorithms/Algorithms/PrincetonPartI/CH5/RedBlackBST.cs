using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms.Algorithms.PrincetonPartI.CH4
{
    public class RedBlackBST<Key, Value> : IEnumerable<Key>
        where Key : IComparable<Key>
    {
        private const bool RED = true;
        private const bool BLACK = false;

        private Node root;

        private class Node
        {
            public Key key;
            public Value val;
            public Node left, right;
            public bool color;
            //public int count;

            public Node(Key key, Value val, bool color)
            {
                this.key = key;
                this.val = val;
                this.color = color;
            }
        }

        public void Put(Key key, Value val) => root = Put(root, key, val);

        private Node Put(Node x, Key key, Value val)
        {
            if (x == null) return new Node(key, val, RED);
            int cmp = key.CompareTo(x.key);
            if (cmp < 0)
                x.left = Put(x.left, key, val);
            else if (cmp > 0)
                x.right = Put(x.right, key, val);
            else if (cmp == 0)
                x.val = val;
            //x.count = 1 + size(x.left) + size(x.right);

            //lean left
            if (IsRed(x.right) && !IsRed(x.left)) x = RotateLeft(x);
            //balance 4-node
            if (IsRed(x.left) && IsRed(x.left.left)) x = RotateRight(x);
            //split 4-node
            if (IsRed(x.left) && IsRed(x.right)) FlipColors(x);

            return x;
        }

        public bool TryGet(Key key, out Value val)
        {
            Node x = root;
            while (x != null)
            {
                int cmp = key.CompareTo(x.key);
                if (cmp < 0) x = x.left;
                else if (cmp > 0) x = x.right;
                else if (cmp == 0)
                {
                    val = x.val;
                    return true;
                }
            }
            val = default;
            return false;
        }

        private Node Min(Node x)
        {
            while (x.left != null)
                x = x.left;
            return x;
        }

        private Node Max(Node x)
        {
            while (x.right != null)
                x = x.right;
            return x;
        }

        private bool IsRed(Node x) => x?.color == RED;

        public void Delete(Key key) => root = Delete(root, key);

        private Node Delete(Node x, Key key)
        {
            //TODO: implement red-black delete
            if (x == null) return null;
            int cmp = key.CompareTo(x.key);
            // search for key
            if (cmp < 0) x.left = Delete(x.left, key);
            else if (cmp > 0) x.right = Delete(x.right, key);
            else
            {
                // no right child
                if (x.right == null) return x.left;
                // no left child
                if (x.left == null) return x.right;

                // replace with successor
                Node t = x;
                x = Min(t.right);
                x.right = DeleteMin(t.right);
                x.left = t.left;
            }
            //x.count = size(x.left) + size(x.right) + 1;
            return x;
        }

        public void DeleteMin() => root = DeleteMin(root);

        private Node DeleteMin(Node x)
        {
            if (x.left == null) return x.right;
            x.left = DeleteMin(x.left);
            //x.count = 1 + size(x.left) + size(x.right);
            return x;
        }

        private Node RotateLeft(Node p)
        {
            Debug.Assert(IsRed(p.right));
            Node x = p.right;
            p.right = x.left;
            x.left = p;
            x.color = p.color;
            p.color = RED;
            return x;
        }

        private Node RotateRight(Node p)
        {
            Debug.Assert(IsRed(p.left));
            Node x = p.left;
            p.left = x.right;
            x.right = p;
            x.color = p.color;
            p.color = RED;
            return x;
        }

        private void FlipColors(Node p)
        {
            Debug.Assert(!IsRed(p));
            Debug.Assert(IsRed(p.left));
            Debug.Assert(IsRed(p.right));
            p.color = RED;
            p.left.color = BLACK;
            p.right.color = BLACK;
        }

        //public int size()
        //{
        //    return size(root);
        //}
        //private int size(Node x)
        //{
        //    if (x == null) return 0;
        //    return x.count;
        //}

        public bool TryFloor(Key key, out Key outKey)
        {
            Node x = Floor(root, key);
            if (x == null)
            {
                outKey = default;
                return false;
            }
            outKey = x.key;
            return true;
        }

        private Node Floor(Node x, Key key)
        {
            if (x == null) return null;
            int cmp = key.CompareTo(x.key);

            if (cmp == 0) return x;

            if (cmp < 0) return Floor(x.left, key);

            Node t = Floor(x.right, key);
            if (t != null) return t;
            else return x;
        }

        public IEnumerator<Key> GetEnumerator()
        {
            return new InorderKeyEnumerator(root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new InorderKeyEnumerator(root);
        }

        private struct InorderKeyEnumerator : IEnumerator<Key>
        {
            Node root;
            Queue<Node> q;

            public InorderKeyEnumerator(Node root)
            {
                this.root = root;
                q = null;
            }

            public Key Current => q == null ? throw new Exception() : q.Peek().key;

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (q == null)
                {
                    q = new Queue<Node>();
                    Inorder(root, q);
                }
                else
                {
                    var x = q.Dequeue();
                    Inorder(x.right, q);
                }

                return q.Count > 0;
            }

            private void Inorder(Node x, Queue<Node> q)
            {
                if (x == null) return;
                Inorder(x.left, q);
                q.Enqueue(x);
            }

            public void Reset()
            {
                q = null;
            }

            public void Dispose()
            {
                root = null;
                q = null;
            }
        }
    }
}
