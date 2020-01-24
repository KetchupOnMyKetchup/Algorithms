using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _108ConvertSortedArrToBST
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

        //    int[] nums = { -10, -3, 0, 5, 9 };

        //    var result = SortedArrayToBST(nums);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            // take middle of sorted array as middle

            // recursively build left and right out w/ helper function
            return Helper(nums, 0, nums.Length);
        }

        /// O(n) time and O(h) space where h is the height of the tree
        private static TreeNode Helper(int[] nums, int left, int right)
        {
            if (left >= right) return null;

            int mid = (left + right) / 2;

            TreeNode newNode = new TreeNode(nums[mid]);

            newNode.left = Helper(nums, left, mid);
            newNode.right = Helper(nums, mid + 1, right);

            return newNode;
        }
    }
}
