using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class QueueLinkedList
    {
        Node top = null;
        public void enqueue(int data)
        {
            Node node = new Node(data);
            if(this.top == null)
            {
                this.top = node;
            }
            else
            {
                Node temp = top;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                
            }
            Console.WriteLine("instered into queue linked list "+node.data);

        }
        public void Display()
        {
            Node temp = top;
            if(temp == null)
            {
                Console.WriteLine("queue linked list is empy");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data +" ");
                    temp = temp.next;
                }
            }
           
        }
        public void Dequeue()
        {
            if(this.top == null)
            {
                Console.WriteLine("the list is empty");
            }
            else
            {
                Console.WriteLine("dequeue from linked list "+this.top.data);
                this.top = this.top.next;
            }
        }
    }
}
