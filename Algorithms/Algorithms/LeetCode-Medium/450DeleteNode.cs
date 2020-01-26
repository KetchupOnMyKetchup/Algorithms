using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _450DeleteNode
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        //public static void Main()
        //{
        //    TreeNode root = new TreeNode(4);
        //    root.left = new TreeNode(2);
        //    root.right = new TreeNode(7);
        //    root.left.left = new TreeNode(1);
        //    root.left.right = new TreeNode(3);

        //    var result = DeleteNode(root, 5);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        public static TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return null;

            // search for node
            if (key > root.val) root.right = DeleteNode(root.right, key);
            else if (key < root.val) root.left = DeleteNode(root.left, key);
            else //key == root.val so.. delete it
            {
                // one child scenario, return that one child instead
                if (root.left == null) return root.right;
                if (root.right == null) return root.left;

                // TO DO go over this
                // if match has 2 children
                TreeNode rightSmallest = root.right;

                // move root.left to be child of root.right.
                while (rightSmallest.left != null) rightSmallest = rightSmallest.left;

                rightSmallest.left = root.left; 
                return root.right;
            }

            return root;
        }
    }
}
