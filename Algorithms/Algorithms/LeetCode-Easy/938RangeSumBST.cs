using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _938RangeSumBST
    {
        public class TreeNode
        {
            public TreeNode(int x) { val = x; }

            public int val;
            public TreeNode left;
            public TreeNode right;
        }

        public static int RangeSumBST(TreeNode root, int L, int R)
        {
            var sum = 0;

            if (root == null) return sum;

            if (root.val > L) // if tree value is greater than lower bound, go left
            {
                // set new root to be 
                sum += RangeSumBST(root.left, L, R);
            }

            if (root.val >= L && root.val <= R)
            {
                sum += root.val;
            }

            if (root.val < R) 
            {
                sum += RangeSumBST(root.right, L, R);
            }

            return sum;
        }

        //static void Main(string[] args)
        //{
        //    var root = new TreeNode(8);

        //    root.left = new TreeNode(3);
        //    root.left.left = new TreeNode(1);
        //    root.left.right = new TreeNode(6);
        //    root.left.right.left = new TreeNode(4);
        //    root.left.right.right = new TreeNode(7);

        //    root.right = new TreeNode(10);
        //    root.right.right = new TreeNode(14);
        //    root.right.left = new TreeNode(13);

        //    Console.WriteLine(RangeSumBST(root, 5, 10).ToString());
        //    Console.ReadLine();
        //}
    }
}
