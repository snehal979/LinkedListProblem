namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddInREverseOrder(30);
            //linkedList.AddInREverseOrder(56);
            linkedList.AddInREverseOrder(70);

            linkedList.InsertedAtParticularPosition(1, 56);
            linkedList.Display();
        }
    }
}