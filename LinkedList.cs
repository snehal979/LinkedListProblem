﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    
    public class LinkedList
    {
        internal Node head;
        /// <summary>
        /// Uc1
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List",node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else
            {
                while(temp != null)
                {
                    Console.WriteLine(temp.data +" ");
                    temp = temp.next;
                }
            }
        }
        /// <summary>
        /// Uc2
        /// </summary>
        /// <param name="data"></param>
        public void AddInREverseOrder(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next= temp;
            }
        }
        /// <summary>
        /// UC3
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        public void InsertedAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if(this.head == null)
            {
                Console.WriteLine(newestNode);
            }
            if (position==0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                Console.WriteLine(this.head);
            }
            else
            {
                Node prev = null;
                Node current = this.head;
                int count = 0;
                while(current != null && count < position)
                {
                    prev = current;
                    current = current.next;
                    count++;
                }
                newestNode.next  = prev.next;
                prev.next =newestNode;
                Console.WriteLine(this.head);
            }
        }
        public void RemoveFirstNode()
        {
            if(this.head == null)
            {
                Console.WriteLine("linked list is empty");

            }
            else
            {
                this.head = this.head.next;
            }
        }

    }
}
