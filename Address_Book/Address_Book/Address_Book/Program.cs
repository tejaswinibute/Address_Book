using System;
using System.Collections.Specialized;
using System.Numerics;
using NLog;
namespace Address_Book
{
    internal class Program
    {
        public static int quit = 0;
        static void Main(string[] args)
        {
            //AddContact[] addContact =new AddContact[4];
            int choiceNumber = 0, recordEntryNumber = 0;
            AddressBookMain addressBookMain = new AddressBookMain();
            // 
            // 
            // //addressBookMain.getContactDetails();
            // addressBookMain.showContactDetails();
            do
            {
                Console.Write("\nSelect Option from below Menu");
                Console.WriteLine("\n 1. Add Contact \n 2. Show Contact List \n 3. Search and Edit Contact");
                Console.WriteLine("\n 1. Add Contact \n 2. Show Contact List \n 3. Search Via Name and Edit Contact \n 4. Search Via Name and Delete Contact");
                Console.Write("\nEnter Choice: ");
                choiceNumber = Convert.ToInt32(Console.ReadLine());
                switch (choiceNumber)
               static void Main(string[] args)
                        addressBookMain.EditContact();
                break;

                    case 4:
                        addressBookMain.DeleteContact();
                break;

                default:
                        Console.Write($"Enter A Value in specified Range");
                break;
            }
                Console.Write("\nDo you want to continue ? \nPress 1 to Continue \nPress 2 to Exit\n");
            Console.Write("\nDo you want to continue in Address Book Main Menu ? \n Press 1 to Continue \n Press 2 to Exit\n");
            Console.Write("\nEnter Choice: ");
            quit = Convert.ToInt32(Console.ReadLine());
        } while (quit !=2);
        }
}
}
 
