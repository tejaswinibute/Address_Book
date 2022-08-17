using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class DeleteContactcs
    {
        public void DeleteContacts()
        {
            do
            {
                Console.WriteLine(" \n Delete Contact Using Name");
                Console.Write("Enter Name : ");
                string searchName = Console.ReadLine();
                foreach (var contact in contactList)
                {
                    if (searchName == contact.firstName)
                    {
                        contactList.Remove(contact);
                        Console.Write($" Coontact Deleted Successfully \n");
                        // addContactDetails();
                    }
                    else if (searchName != contact.firstName)
                    {
                        Console.WriteLine("No contacts has been added in list \n Please add contacts and try again");
                    }
                    else
                    {
                        Console.Write($"\nContact Not Found");
                    }
                }
                //Console.WriteLine("1.Edit Contact Using Name");
                Console.WriteLine("Do you want to continue? \nEnter 1 For YES and 2 For NO");
                Console.WriteLine("Do you want to continue deleting contacts in Addressbook? \n Enter 1 For 'YES' and 2 For 'NO' ");
                ch = Convert.ToInt32(Console.ReadLine());
            } while (ch != 2);
            Console.WriteLine("Exit from Edit Contact.");
            Console.WriteLine("Exit from Delete Menu");
        }
    }
} 
    }
}
