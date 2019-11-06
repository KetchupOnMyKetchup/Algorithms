using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class BSTtoGST
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        static int sum = 0;

        public static TreeNode BstToGst(TreeNode root)
        {
            // traverse to bottom right
            if (root.right != null) BstToGst(root.right);

            sum += root.val;
            root.val = sum;

            if (root.left != null) BstToGst(root.left);

            return root;
        }

        //public static void Main()
        //{
        //    var left = new TreeNode(1)
        //    {
        //        left = new TreeNode(0),
        //        right = new TreeNode(2)
        //    };

        //    left.right.right = new TreeNode(3);

        //    var right = new TreeNode(6)
        //    {
        //        left = new TreeNode(5),
        //        right = new TreeNode(7)
        //    };

        //    right.right.right = new TreeNode(8);

        //    var root = new TreeNode(4)
        //    {
        //        left = left,
        //        right = right
        //    };

        //    var soln = BstToGst(root);
        //    Console.WriteLine();
        //    Console.ReadLine();
        //}
    }
}
