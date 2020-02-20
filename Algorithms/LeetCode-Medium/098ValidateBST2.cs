using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _098ValidateBST2
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
        //    TreeNode root = new TreeNode(10);
        //    root.left = new TreeNode(5);
        //    root.right = new TreeNode(15);
        //    root.right.left = new TreeNode(6);
        //    root.right.right = new TreeNode(20);

        //    var result = IsValidBST(root);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        public static bool IsValidBST(TreeNode root)
        {
            return CheckTree(root, null, null);
        }

        private static bool CheckTree(TreeNode node, int? lower, int? upper)
        {
            if (node == null) return true;

            int val = node.val;
            if (upper != null && val >= upper) return false;
            if (lower != null && val <= lower) return false;

            if (!CheckTree(node.right, val, upper)) return false;
            if (!CheckTree(node.left, lower, val)) return false;

            return true;
        }
    }
}
