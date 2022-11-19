using LinkedListProblem;

namespace LinkedListMSTesting
{
    [TestClass]
    public class UnitTest1
    {
        LinkedList linkedList = new LinkedList();
        [TestMethod]
        /// Uc7 MSTesting search
       
        public void SearchLinkedList_MSTest()
        {
           
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.InsertedAtParticularPosition(1, 40);
            linkedList.Display();

            //AAA test method
            int b = linkedList.Search(40);

            int actual = 1; // 40 at 1 position
            Assert.AreEqual(actual, b);
            // Delect
            linkedList.DelectAtparticularPosition(1);
            int size = linkedList.Size();
            Assert.AreEqual(size, 3) ;

            
            
           
           
            
           
           

            
           
        }
       
    }
}