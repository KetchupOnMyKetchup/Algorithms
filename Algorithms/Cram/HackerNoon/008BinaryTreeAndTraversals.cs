using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.HackerNoon
{
    class _008BinaryTreeAndTraversals
    {
        class Node
        {
            public Node(int value)
            {
                Data = value;
            }

            public int Data;
            public Node leftNode;
            public Node rightNode;
        }

        class Tree
        {
            Node _root;

            public Node GetNode()
            {
                return _root;
            }

            public void Insert(int value)
            {
                if (_root == null)
                {
                    _root = new Node(value);
                }

                Node current = _root;
                Node parent; 

                while (true)
                {
                    parent = current;  // DONT FORGET

                    if (value > current.Data)
                    {
                        current = current.rightNode;
                        if (current == null)
                        {
                            current = new Node(value);
                            return; // DONT FORGET
                        }
                    }
                    else
                    {
                        current = current.leftNode;
                        if (current == null)
                        {
                            current = new Node(value);
                            return;  // DONT FORGET
                        }
                    }
                }
                
            }

            public void PreOrder(Node node)
            {
                if (node != null)
                {
                    Console.WriteLine(node.Data);
                    PreOrder(node.leftNode);
                    PreOrder(node.rightNode);
                }
            }

            public void InOrder(Node node)
            {
                if (node != null)
                {
                    PreOrder(node.leftNode);
                    Console.WriteLine(node.Data);
                    PreOrder(node.rightNode);
                }
            }

            public void PostOrder(Node node)
            {
                if (node != null)
                {
                    PreOrder(node.leftNode);
                    PreOrder(node.rightNode);
                    Console.WriteLine(node.Data);
                }
            }

        }


    }
}
