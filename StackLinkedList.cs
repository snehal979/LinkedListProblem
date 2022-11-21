using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class StackLinkedList
    {
        Node top;
        public StackLinkedList()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if(this.top == null)
            {
                this.top = null;
            } else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("push the value  in stack is "+data); 
        }
        public void Display()
        {
            Node temp = this.top;
            if(temp == null)
            {
                Console.WriteLine("stak is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("stack is null");
                return;
            }
            Console.WriteLine("the peek value in stack is "+this.top.data);
        }
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("the stack is empty");

            }
            Console.WriteLine(" the pop of data from stack is "+this.top.data);
            this.top = this.top.next;
        }
        public void Empty()
        {
            while(this.top !=null)
            {
                Peek();
                Pop();
             
            }
        }
    }
}
