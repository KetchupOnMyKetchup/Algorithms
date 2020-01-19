using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    /// <summary>
    /// This should be Medium not Easy level
    /// </summary>
    class _437PathSum
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
        //    var root = new TreeNode(10);
        //    root.left = new TreeNode(5);
        //    root.right = new TreeNode(-3);

        //    root.left.left = new TreeNode(3);
        //    root.left.right = new TreeNode(2);
        //    root.right.right = new TreeNode(11);

        //    var result = PathSum(root, 8); // answer should be 2

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        static int count = 0;
        static int _sum = 0;

        public static int PathSum(TreeNode root, int sum)
        {
            _sum = sum;
            Traverse(root);
            return count;
        }

        // Recursively pretend each node is its own tree, and search down each tree entirely to check for sum
        private static void Traverse(TreeNode root)
        {
            if (root == null) return;

            TryPath(root, 0);
            Traverse(root.left);
            Traverse(root.right);
        }

        private static void TryPath(TreeNode root, int currSum)
        {
            if (root == null) return;

            currSum += root.val;
            if (currSum == _sum) count++;

            TryPath(root.left, currSum);
            TryPath(root.right, currSum);

            currSum -= root.val;
        }
    }
}
