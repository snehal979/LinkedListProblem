using System.Xml.Serialization;

namespace AddressBookData
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            bool flag = true;
            AddressBookMain addressBookMain = new AddressBookMain();
            while(flag)
            {

                Console.WriteLine("Select 1.CreateContact \n 2.Edit Contact\n 3.Delete contact \n4.Display contacts \n5.Create Dictionary \n6.Display Dictionary\n 7.Exit");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBookMain.NewCreateContact();
                        break;
                    case 2:
                        addressBookMain.UpdateContact();
                        break;
                    case 3:
                        addressBookMain.DeleteContact();
                        break;
                    case 4:
                        addressBookMain.Display();
                        break;
                    case 5:
                        addressBookMain.CreateDictionary();
                        break;
                    case 6:
                        addressBookMain.DisplayDictionary();
                        break;
                    case 7:
                        flag = false;
                        break;

                }

            } 

            
        }
    }
}
