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

            //AAA test method
            int a =linkedList.Search(30);

            int actual = 0; // 30 at zero position
            Assert.AreEqual(actual, a);

            linkedList.InsertedAtParticularPosition(1, 40);
            int b = linkedList.Search(40);
            int actualB = 1;
            Assert.AreEqual(actualB, b);
           
        }
       
    }
}