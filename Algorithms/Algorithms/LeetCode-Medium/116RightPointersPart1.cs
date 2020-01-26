using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _116RightPointers
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }

            //public static void Main()
            //{
            //    Node root = new Node(1);
            //    root.left = new Node(2);
            //    root.right = new Node(3);
            //    root.left.left = new Node(4);
            //    root.left.right = new Node(5);
            //    root.right.right = new Node(6);

            //    Connect(root);

            //    Console.WriteLine();
            //    Console.ReadLine();
            //}

            // B2B software explains part 1 and part 2 well
            // Time: O(n)
            // Space: O(h) where h is height of tree (logarithmic if balanced, linear if skewed tree)
            public static Node Connect(Node root)
            {
                if (root == null) return null;
                
                if (root.left != null)
                {
                    root.left.next = root.right;  
                }
                if (root.right != null && root.next != null)
                {
                    root.right.next = root.next.left;
                }

                root.left = Connect(root.left);
                root.right = Connect(root.right);

                return root;
            }
        }
    }
}