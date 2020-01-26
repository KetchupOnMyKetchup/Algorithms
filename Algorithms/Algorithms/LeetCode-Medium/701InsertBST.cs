using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _701InsertBST
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

        //    var result = InsertIntoBST(root, 5);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        // https://www.geeksforgeeks.org/insert-a-node-in-binary-search-tree-iteratively/
        // When inserting into BST, you will always insert it at the bottom as a leaf. 
        // You will not be re-arranging tree
        public static TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);
            
            if (val > root.val)
            {
                root.right = InsertIntoBST(root.right, val);
            }
            else
            {
                root.left = InsertIntoBST(root.left, val);
            }

            return root;
        }
    }
}
