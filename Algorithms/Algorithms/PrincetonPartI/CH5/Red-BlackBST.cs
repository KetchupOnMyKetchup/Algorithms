//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Algorithms.Algorithms.PrincetonPartI.CH5
//{
//    /// <summary>
//    /// Each node is pointed to by 1 link (from its parent). Can encode color of links in Nodes. 
//    /// </summary>
//    public class Red_BlackBST<Key, Value>
//    {
//        private static bool RED = true;
//        private static bool BLACK = false;
//        private class Node
//        {
//            public Key key;
//            public Value val;
//            public Node left, right;
//            public bool color; // color of parent link
//        }

//        private bool isRed(Node x)
//        {
//            if (x == null) return false; // null links are black
//            return x.color == RED;
//        }
//        public Val get(Key key)
//        {
//            Node x = root;
//            while (x != null)
//            {
//                int cmp = key.compareTo(x.key);
//                if (cmp < 0) x = x.left;
//                else if (cmp > 0) x = x.right;
//                else if (cmp == 0) return x.val;
//            }
//            return null;
//        }

//        private Node rotateLeft(Node h)
//        {
//            if (isRed(h.right))
//            {
//                Node x = h.right;
//                h.right = x.left;
//                x.left = h;
//                x.color = h.color;
//                h.color = RED;
//                return x;
//            }

//            return h;
//        }

//        private Node rotateRight(Node h)
//        {
//            if (isRed(h.left))
//            {
//                Node x = h.left;
//                h.left = x.right;
//                x.right = h;
//                x.color = h.color;
//                h.color = RED;
//                return x;
//            }

//            return h;
//        }
//    }
//}
