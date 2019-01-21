using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Data_Structures.Binary_Tree
{
    // If a number is smaller, goes to left. If bigger, goes to right. 
    // Quicker to search than to use LinkedList
    public class BinaryTree<T> : IEnumerable<T>
        where T: IComparable<T>
    {
        private BinaryTreeNode<T> _head;
        private int _count;

        public void Add(T value)
        {
            // Case 1: If the tree is empty, allocate the head
            if (_head == null)
            {
                _head = new BinaryTreeNode<T>(value);
            }
            // Case 2: If the tree is not empty, find the right location to insert
            else
            {
                AddTo(_head, value);
            }

            _count++;
        }

        // Remove: Find node to be deleted. Then, 3 possible scenarios of what to do: 
        // If it doesn't exist, exit
        // If it is a leaf (terminal node), remove the parent's pointer to the deleted node
        // If it is a non-leaf node, find the child to replace the deleted node. 

        // If for ex. node to remove has no right child, promote its left child into its place. 
        // Remove a node that has a right grandchild, but no left grandchild 3:50 https://app.pluralsight.com/player?course=ads-part1&author=robert-horvick&name=ads-binarytree&clip=5&mode=live
        public bool Remove(T value)
        {
            BinaryTreeNode<T> current, parent;

            current = FindWithParent(value, out parent);

            if (current == null) return false;

            _count--;

            // Case 1: If current has no right child, then current's left replaces current
            if (current.Right == null)
            {
                if (parent == null)
                {
                    _head = current.Left;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        parent.Left = current.Left;
                    }
                    else if (result < 0)
                    {
                        parent.Right = current.Left;
                    }
                }
            }
            // Case 2: If current's right child has no left child, then current's right child replaces current
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                if (parent == null)
                {
                    _head = current.Right;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);

                    if (result > 0) parent.Left = current.Right;
                    else if (result < 0) parent.Right = current.Right;
                }
            }
            // Case 3: If current's right child has a left child, replace current with current's right child's left most child
            else
            {
                BinaryTreeNode<T> leftmostParent = current.Right;
                BinaryTreeNode<T> leftmost = leftmostParent.Left;

                while (leftmost.Left != null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }

                // the parent's left subtree becomes the leftmost's right subtree
                leftmostParent.Left = leftmost.Right;

                // assign leftmost's left and right to current's left and right children
                leftmost.Left = current.Left;
                leftmost.Right = current.Right;

                if (parent == null) _head = leftmost;
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        parent.Left = leftmost;
                    }
                    else if (result < 0)
                    {
                        parent.Right = leftmost;
                    }
                }
            }

            return true;
        }

        // Process what node you are on, visit left, then visit right
        // Seems like a 'random' order, but the point is every time you do this method you get the same result
        public void PreOrderTraversal(Action<T> action)
        {
            PreOrderTraversal(action, _head);
        }

        private void PreOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                action(node.Value);
                PreOrderTraversal(action, node.Left);
                PreOrderTraversal(action, node.Right);
            }
        }

        // "dependency graph, shows which children depend on which parent"
        public void PostOrderTraversal(Action<T> action)
        {
            PostOrderTraversal(action, _head);
        }

        private void PostOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                action(node.Value);
                PostOrderTraversal(action, node.Left);
                PostOrderTraversal(action, node.Right);
            }
        }

        // Starts at left bottom most node
        // Processes in order from lowest # to highest
        public void InOrderTraversal(Action<T> action)
        {
            InOrderTraversal(action, _head);
        }

        private void InOrderTraversal(Action<T> action, BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(action, node.Left);
                action(node.Value);
                InOrderTraversal(action, node.Right);
            }
        }

        public IEnumerator<T> InOrderTraversal()
        {
            if (_head != null)
            {
                Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();

                BinaryTreeNode<T> current = _head;

                bool goLeftNext = true;

                stack.Push(current);

                while (stack.Count > 0)
                {
                    if (goLeftNext)
                    {
                        while (current.Left != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }

                    yield return current.Value;

                    // if we can go right, do so
                    if (current.Right != null)
                    {
                        current = current.Right;
                        goLeftNext = true;
                    }
                    else
                    {
                        current = stack.Pop();
                        goLeftNext = false;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Contains(T value)
        {
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        public void Clear()
        {
            _head = null;
            _count = 0;
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> current = _head;
            parent = null;

            // while we don't have a match
            while (current == null)
            {
                int result = current.CompareTo(value);

                if (result > 0)
                {
                    // if parent is less than current, go left
                    parent = current;
                    current = current.Left;
                }
                else if (result > 0)
                {
                    // if value is more than current, go right
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    // it matches!
                    break;
                }
            }

            return current;
        }

        // Recursive add algorithm
        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            // Case 1: Value is less than current node value
            if (value.CompareTo(node.Value) < 0)
            {
                // if there is no left child, make this the new left
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // else add it to the left node
                    AddTo(node.Left, value);
                }
            }
            // Case 2: Value is equal to or greater than current value
            else
            {
                // If there is no right, add it to the right
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // else, add it to the right node
                    AddTo(node.Right, value);
                }
            }
        }
    }
}
