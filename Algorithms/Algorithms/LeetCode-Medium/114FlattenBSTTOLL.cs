using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _114FlattenBSTTOLL
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        //static void Main()
        //{
        //    TreeNode root = new TreeNode(1);
        //    root.left = new TreeNode(2);
        //        root.left.left = new TreeNode(3);
        //        root.left.right = new TreeNode(4);
    
        //    root.right = new TreeNode(5);
        //        root.right.right = new TreeNode(6);

        //    Flatten(root);
        //    Console.WriteLine();
        //}

        static TreeNode prev = null;

        // Given a binary tree, flatten it to a linked list in-place.
        public static void Flatten(TreeNode root)
        {
            if (root == null) return;

            Flatten(root.right); // have to go down right side first
            Flatten(root.left);

            root.right = prev; // prev will be left root potentially
            root.left = null;

            prev = root;
        }
    }
}
