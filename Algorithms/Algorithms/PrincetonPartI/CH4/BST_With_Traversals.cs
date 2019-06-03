using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH4
{
    /// <summary>
    /// Traversal explanations: https://www.c-sharpcorner.com/UploadFile/19b1bd/binarysearchtreewalkstraversal-implementation-using-C-Sharp/
    /// 
    /// </summary>
    class BST_With_Traversals
    {
        class Node
        {
            public int item;
            public Node leftc;
            public Node rightc;
            public void display()
            {
                Console.Write("[");
                Console.Write(item);
                Console.Write("]");
            }
        }
        class Tree
        {
            public Node root;
            public Tree()
            {
                root = null;
            }
            public Node ReturnRoot()
            {
                return root;
            }
            public void Insert(int id)
            {
                Node newNode = new Node();
                newNode.item = id;
                if (root == null)
                    root = newNode;
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (id < current.item)
                        {
                            current = current.leftc;
                            if (current == null)
                            {
                                parent.leftc = newNode;
                                return;
                            }
                        }
                        else
                        {
                            current = current.rightc;
                            if (current == null)
                            {
                                parent.rightc = newNode;
                                return;
                            }
                        }
                    }
                }
            }
            public void Preorder(Node Root)
            {
                if (Root != null)
                {
                    Console.Write(Root.item + " ");
                    Preorder(Root.leftc);
                    Preorder(Root.rightc);
                }
            }
            public void Inorder(Node Root)
            {
                if (Root != null)
                {
                    Inorder(Root.leftc);
                    Console.Write(Root.item + " ");
                    Inorder(Root.rightc);
                }
            }
            public void Postorder(Node Root)
            {
                if (Root != null)
                {
                    Postorder(Root.leftc);
                    Postorder(Root.rightc);
                    Console.Write(Root.item + " ");
                }
            }
        }

    }
}
