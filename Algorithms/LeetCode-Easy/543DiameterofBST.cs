using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class _543DiameterofBST
    {
        //public static void Main()
        //{
        //    var root = new TreeNode(1);

        //    var result = DiameterOfBinaryTree(root);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        static int maxPath = 1;

        public static int DiameterOfBinaryTree(TreeNode root)
        {
            LongestPath(root);
            return maxPath;
        }

        private static int LongestPath(TreeNode curr)
        {
            if (curr == null) return 0;

            int left = LongestPath(curr.left);
            int right = LongestPath(curr.right);

            maxPath = Math.Max(maxPath, left + right);

            return Math.Max(left, right) + 1;
        }
    }
}
