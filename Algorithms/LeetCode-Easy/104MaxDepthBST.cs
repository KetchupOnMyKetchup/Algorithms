using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _104MaxDepthBST
    {
         public class TreeNode
         {
             public int val;
             public TreeNode left;
             public TreeNode right;
             public TreeNode(int x) { val = x; }
         }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var left = MaxDepth(root.left);
            Console.WriteLine(left);
            var right = MaxDepth(root.right);
            Console.WriteLine(right);

            return 1 + Math.Max(left, right);
        }

        //public static void Main()
        //{
        //    var root = new TreeNode(3)
        //    {
        //        left = new TreeNode(9),
        //        right = new TreeNode(20)
        //    };
        //    root.right.left = new TreeNode(15);
        //    root.right.right = new TreeNode(7);

        //    Console.WriteLine(MaxDepth(root));
        //    Console.ReadLine();
        //}
    }
}
