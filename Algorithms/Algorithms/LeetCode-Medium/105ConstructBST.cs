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
            int[] preorder = { 3, 9, 20, 15, 7 }; // node, left right
            int[] inorder = { 9, 3, 15, 20, 7 }; // left, node, right

            var result = BuildTree(preorder, inorder); 

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return Build(0, 0, inorder.Length - 1, preorder, inorder);
        }

        private static TreeNode Build(int preOrderStart, int inOrderStart, int inEnd, int[] preorder, int[] inorder)
        {
            if (preOrderStart > preorder.Length - 1 || inOrderStart > inEnd)
                return null;

            // 3 9 20 15 7
            // first root is 3 from preorder
            TreeNode root = new TreeNode(preorder[preOrderStart]);

            int rootIndex = 0; // create new var RootIndex

            // Loop through inorder to find  root 9 3 15 20 7
            for (int i = inOrderStart; i <= inEnd; i++)
            {
                if (inorder[i] == root.val) rootIndex = i; // the index of 3 in the inorder is 1, set rootIndex to 1
            }

            // divide the inorder list into left and right based on rootIndex = 3!!! 3 is already accounted for so everything around it. 
            // 9 3 15 20 7

            // left half is 9
            // prestart increments 1 because we just set that in line 38 and its used
            // inorder start doesnt change because we're anywhere to the left of rootindex
            // inorder end - 1 because the furthest we can go in left half is 1 left of the root (9 in this case)
            root.left = Build(preOrderStart + 1, inOrderStart, rootIndex - 1, preorder, inorder);

            // If we get the length of the left tree from the inOrder, that length is the same as the preOrder list
            // We can use this to find out where the preOrder right side should start
            int leftTreeLength = rootIndex - inOrderStart;

            // right half is 15 20 7
            // preOrderStart for right half is whereever left PreOrder starts + length of Left Tree + 1
            // inOrderStart is 1 to the right of rootIndex
            // inorder end is still the end of the int array, right side will always end at the very end so won't increment
            root.right = Build(preOrderStart + leftTreeLength + 1, rootIndex + 1, inEnd, preorder, inorder);

            return root;
        }
    }
}
