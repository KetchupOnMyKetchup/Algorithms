using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _105ConstructBST
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public static void Main()
        {
            int[] preorder = { 3, 9, 20, 15, 7 };
            int[] inorder = { 9, 3, 15, 20, 7 };

            var result = BuildTree(preorder, inorder); 

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            TreeNode root = new TreeNode(0);



            return root;
        }
    }
}
