// <copyright file="BinarySearchTree.cs" >
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Sushant hiremath</author>
// <date>11/05/2017 11:39:58 AM </date>
// <summary>Class representing a Sample entity</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BST");
            BinarySTree theTree = new BinarySTree();
            theTree.Insert(20);
            theTree.Insert(25);
            theTree.Insert(45);
            theTree.Insert(15);
            theTree.Insert(67);
            theTree.Insert(43);
            theTree.Insert(80);
            theTree.Insert(33);
            theTree.Insert(67);
            theTree.Insert(99);
            theTree.Insert(91);
            Console.WriteLine("Inorder Traversal : ");
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.ReadLine();

            Console.ReadLine();
        }
    }

    class Bnode
    {
        public object Value;
        public Bnode Right,Left;

        public Bnode()
        {
            Right = Left = null;
        }

    }

    class BinarySTree
    {
        Bnode Root = null;
        Bnode Current = null;
        public Bnode ReturnRoot()
        {
            return Root;
        }

        public BinarySTree()
        {
            Root = new Bnode();
            Current = Root;
        }

        public bool Insert(object data)
        {
            Bnode NewNode = new Bnode() { Value = data };
            Bnode TempParent;

            if (Root.Value == null)
            {
                Root = NewNode;
                return true;
            }
            else
            {
                Current = Root;

                while (true)
                {
                    TempParent = Current;
                    if (Convert.ToInt32(NewNode.Value) < Convert.ToInt32(Current.Value))
                    {
                        Current = Current.Left;
                        if (Current == null)
                        {
                            TempParent.Left = NewNode;
                            return true;
                        }
                    }
                    else
                    {
                        Current = Current.Right;
                        if (Current == null)
                        {
                            TempParent.Right = NewNode;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public void Preorder(Bnode Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Value + " ");
                Preorder(Root.Left);
                Preorder(Root.Right);
            }
        }
        public void Inorder(Bnode Root)
        {
            if (Root != null)
            {
                Inorder(Root.Left);
                Console.Write(Root.Value + " ");
                Inorder(Root.Right);
            }
        }
        public void Postorder(Bnode Root)
        {
            if (Root != null)
            {
                Postorder(Root.Left);
                Postorder(Root.Right);
                Console.Write(Root.Value + " ");
            }
        }
    }
}
