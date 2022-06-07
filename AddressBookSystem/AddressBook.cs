using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        List<Contact> addressBook = new List<Contact>();
        public AddressBook()
        {
            Contact address1 = new Contact()
            {
                FirstName = "Mohan",
                LastName = "sahu",
                Address = "bhiai",
                City = "Durg",
                State = "cg",
                EmailAddress = "Mohan@14gmail.com",
                PostalCode = 54665,
                MobileNumber = 7898521457
            };
            Contact address2 = new Contact()
            {
                FirstName = "govind",
                LastName = "bhatt",
                Address = "pandaria",
                City = "kawardha",
                State = "chhattisgarh",
                EmailAddress = "bhatt@12gmail.com",
                PostalCode = 521014,
                MobileNumber = 9320514785
            };
            Console.WriteLine("Enter the FirstName,LastName,Address,City,State,Email,postalCode,mobile,Number");
            Contact address3 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                EmailAddress = Console.ReadLine(),
                PostalCode = Convert.ToInt32(Console.ReadLine()),
                MobileNumber = Convert.ToInt64(Console.ReadLine())
            };
            addressBook.Add(address1);
            addressBook.Add(address2);
            addressBook.Add(address3);
        }
        public void AddContactToAddressBook(Contact contact)
        {
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);
            }
        }
        public void EditContactInAddressBook(string name)
        {
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Enter Option To Update");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter Firstname to Update");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Lastname to Update");
                            contact.LastName = Console.ReadLine(); 
                            break;
                        case 3:
                            Console.WriteLine("Enter Address to Update");
                            contact.Address = Console.ReadLine(); 
                            break;
                        case 4:
                            Console.WriteLine("Enter City to Update");
                            contact.City = Console.ReadLine(); 
                            break;
                        case 5:
                            Console.WriteLine("Enter State to Update");
                            contact.State = Console.ReadLine(); 
                            break;
                        case 6:
                            Console.WriteLine("Enter Email to Update");
                            contact.EmailAddress = Console.ReadLine(); 
                            break;
                        case 7:
                            Console.WriteLine("Enter the Postal to Update");
                            contact.PostalCode = Convert.ToInt32(Console.ReadLine()); 
                            break;
                        case 8:
                            Console.WriteLine("Enter the MobileNumber to Update");
                            contact.MobileNumber = Convert.ToInt64(Console.ReadLine()); 
                            break;
                    }
                }
                Display();
            }
        }
        public void DeletingContactINAddressBook(string name)
        {
            Contact delete = new Contact();
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            Display();
        }
    }
}