using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH4
{
    /// <summary>
    /// If N is random, search/insert is 2 ln N
    /// Worst case is when N is already sorted
    /// Expected height of tree (random) is 4.3 ln N
    /// </summary>
    public class BST_Simple
    {
        class Node
        {
            public int value;
            public Node left;
            public Node right;
        }

        class Tree
        {
            public Node insert(Node root, int v)
            {
                if (root == null)
                {
                    root = new Node();
                    root.value = v;
                }
                else if (v < root.value)
                {
                    root.left = insert(root.left, v);
                }
                else
                {
                    root.right = insert(root.right, v);
                }

                return root;
            }

            public void traverse(Node root)
            {
                if (root == null)
                {
                    return;
                }

                traverse(root.left);
                traverse(root.right);
            }
        }
    }
}