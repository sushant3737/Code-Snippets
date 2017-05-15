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

        public int Count
        {
            get { return size; }
        }

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
            while (CurrentNodepos != null)
            {

                if ((count == x-1) && (x >= 0 && x<= size))
                {
                    CurrentNodepos.Link = CurrentNodepos.Link.Link;
                    size--;
                    return true;
                }
                count++;
                CurrentNodepos = CurrentNodepos.Link;

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

        public object getelementAt(int x)
        {
            int count = 0;
            Node CurrentNodepos = new Node();
            CurrentNodepos = Header;
            while (CurrentNodepos.Link != null)
            {
                if (count == x)
                {
                    return CurrentNodepos.Link;
                }
                count++;
                CurrentNodepos = CurrentNodepos.Link;
            }
            return -1;
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

    class Lstack
    {
        LinkedList Llist = null;
        public Lstack()
        {
            Llist = new LinkedList();
        }

        public void push(object obj)
        {
            Llist.Add(obj);
        }
        public object pop()
        {
            if (Llist.Count > 0)
            {
                object temp = Llist.getelementAt(Llist.Count -1);
                Llist.RemoveAt(Llist.Count);
                return temp;
            }
            return -1;
        }
        public object peek()
        {
            if (Llist.Count > 0)
            {
                object temp = Llist.getelementAt(Llist.Count - 1);
                return temp;
            }
            return -1;
        }
    }

    class LQueue
    {
      LinkedList Llist = null;
      public LQueue()
      {
          Llist = new LinkedList();
      }

      public void Enqueue(object obj)
      {
          Llist.AddFirst(obj);
      }
      public object Dequeue()
      {
          if (Llist.Count > 0)
          {
              object temp = Llist.getelementAt(Llist.Count - 1);
              Llist.RemoveAt(Llist.Count);
              return temp;
          }
          return -1;
      }
      public object peek()
      {
          if (Llist.Count > 0)
          {
              object temp = Llist.getelementAt(Llist.Count - 1);
              return temp;
          }
          return -1;
      }
        
    }
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList ls = new LinkedList();
            ls.Add(21);
            ls.Add(22);
            ls.Add(23);
            ls.Add(24);
            ls.Add(25);
            ls.Add(26);
            ls.Add(26);
            ls.InsertAt(7, 30);
            ls.RemoveAt(8);
            object obj = ls.getelementAt(6);
            Console.WriteLine("Linked List");
            ls.PrintAllNodes();
            Console.WriteLine();
            Lstack lstk = new Lstack();
            lstk.push(21);
            lstk.push(22);
            object se = lstk.pop();
            Node ex = (Node)se;
            Console.WriteLine("Stack using linked list");
            Console.WriteLine(ex.Value);
            se = lstk.pop();
            ex = (Node)se;
            Console.WriteLine(ex.Value);
            Console.WriteLine();

            LQueue lQ= new LQueue();
            lQ.Enqueue(21);
            lQ.Enqueue(22);
            se = lQ.Dequeue();
            ex = (Node)se;
            Console.WriteLine("Queue using linked list");
            Console.WriteLine(ex.Value);
            se = lQ.Dequeue();
            ex = (Node)se;
            Console.WriteLine(ex.Value);
            Console.ReadLine();
        }
    }
}
