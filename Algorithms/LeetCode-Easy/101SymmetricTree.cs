using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _101SymmetricTree
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
        //    var root = new TreeNode(1);

        //    var result = IsSymmetric(root);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        public static bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }

        private static bool IsMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;

            return (t1.val == t2.val)
                && IsMirror(t1.right, t2.left)
                && IsMirror(t1.left, t2.right);
        }
    }
}
