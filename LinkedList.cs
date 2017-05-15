// <copyright file="LinkedList.cs" >
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Sushant hiremath</author>
// <date>11/05/2017 11:39:58 AM </date>
// <summary>Class representing a Sample entity</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public Object Value;
        public Node Link;

        //Node Constructor
        public Node()
        {
            Value = null;
            Link = null;
        }
        public Node(object obj)
        {
            Value = obj;
            Link = null;
        }
    }

    class LinkedList
    {
        Node Header;
        Node Current;
        int size = 0;
        public LinkedList()
        {
            Header = new Node();
            Current = Header;
        }
        public bool Add(object addobj)
        {
            Node Newnode = new Node() { Value = addobj };
            Current.Link = Newnode;
            Current = Newnode;
            size++;
            return true;
        }

        public bool AddFirst(object addobj)
        {
            Node Newnode = new Node() { Value = addobj };
            Newnode.Link = Header.Link;
            Header.Link = Newnode;
            size++;
            return true;
        }
        public bool RemoveAt(int x)
        {
            int count = 0;
            Node CurrentNodepos = new Node();
            CurrentNodepos = Header;
            if (x == 1)
            {
                CurrentNodepos.Link = CurrentNodepos.Link.Link;
                size--;
                return true;
            }
            while (CurrentNodepos != null)
            {
                count++;
                CurrentNodepos = CurrentNodepos.Link;
                if (count == x)
                {
                    CurrentNodepos.Link = CurrentNodepos.Link.Link;
                    size--;
                    return true;
                }
            }
            return false;
        }

        public bool InsertAt(int x,object obj)
        {
            Node Newnode = new Node() { Value = obj };
            Node CurrentNodepos = new Node();
            CurrentNodepos = Header;
            if (x == 0)
            {
                AddFirst(obj);
                size++;
                return true;
            }
            else if (x == size - 1)
            {
                Add(obj);
                size++;
                return true;
            }
            else
            {
                int count = 0;
                while (CurrentNodepos != null)
                {

                    if (count == x)
                    {
                        Node temp = new Node();
                        temp = CurrentNodepos;
                        Newnode.Link = CurrentNodepos.Link;
                        temp.Link = Newnode;
                        size++;
                        return true;
                    }
                    count++;
                    CurrentNodepos = CurrentNodepos.Link;
                }
            }

            return false;
        }

        public bool PrintAllNodes()
        {
            Node CurrentNodepos = new Node();
            CurrentNodepos = Header;
            while (CurrentNodepos != null)
            {
                Console.WriteLine(CurrentNodepos.Value);
                CurrentNodepos = CurrentNodepos.Link;
            }
            return true;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList ls = new LinkedList();
            ls.Add(21);
            ls.Add(23);
            ls.Add(24);
            ls.Add(25);
            ls.Add(26);
            ls.Add(27);
            ls.AddFirst(20);
            ls.InsertAt(8,30);
            ls.PrintAllNodes();
            Console.ReadLine();
        }
    }
}
