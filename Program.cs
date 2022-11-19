namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Add(70);
            Console.WriteLine("1.add \n 2.addinsertedat position\n 3.display\n 4.removefirst\n5.removelast\n6.search position of value\n 7.reversemethod \n 8.size\n 9.delectatPostion");
            int choice =Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    linkedList.Add(78);
                    
                    linkedList.Display();
                    break;
                case 2:
                    linkedList.InsertedAtParticularPosition(3, 45);
                    linkedList.Display();
                    break;
                case 3:
                    linkedList.Display();
                    break;
                case 4:
                    linkedList.RemoveFirstNode();
                    linkedList.Display();
                    break;
                case 5:
                    linkedList.LastRemove();
                    linkedList.Display();
                    break;
                case 6:
                    int a =linkedList.Search(79);
                    Console.WriteLine(a);

                    linkedList.SearchNUM(98);

                    break;
                case 7:
                    linkedList.AddInREverseOrder(30);
                    linkedList.AddInREverseOrder(56);
                    linkedList.AddInREverseOrder(70);
                    linkedList.Display();

                    break;
                case 8:
                    linkedList.Size();
                    break;
                    case 9:
                    linkedList.DelectAtparticularPosition(1);
                    break;
                
            }
            
           
            

            

            
            




        }
    }
}