using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class ValidateBST
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public static bool IsValidBST(TreeNode root)
        {
            return isValidBST(root, long.MinValue, long.MaxValue);
        }

        public static bool isValidBST(TreeNode root, long minVal, long maxVal)
        {
            if (root == null) return true;

            if (root.val >= maxVal || root.val <= minVal) return false;

            return (isValidBST(root.left, minVal, root.val) && isValidBST(root.right, root.val, maxVal));
        }

        public static void Main()
        {
            var right = new TreeNode(15)
            {
                left = new TreeNode(6),
                right = new TreeNode(20)
            };

            var root = new TreeNode(10)
            {
                left = new TreeNode(5),
                right = right
            };

            Console.WriteLine(IsValidBST(root));
            Console.ReadLine();
        }
    }
}
