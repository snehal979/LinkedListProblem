namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Console.WriteLine("1.add \n 2.addinsertedat position\n 3.display\n 4.removefirst\n5.removelast\n6.search position of value\n 7.reversemethod");
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.Display();
            //linkedList.AddInREverseOrder(30);
            //linkedList.AddInREverseOrder(56);
            //linkedList.AddInREverseOrder(70);

            //linkedList.InsertedAtParticularPosition(1, 56);

            //linkedList.Display();

            //linkedList.RemoveFirstNode();
            //linkedList.Display();
            //linkedList.LastRemove();
            //linkedList.Display();
            //int a =linkedList.Search(79);
            //Console.WriteLine(a);

            linkedList.SearchNUM(98);
            




        }
    }
}