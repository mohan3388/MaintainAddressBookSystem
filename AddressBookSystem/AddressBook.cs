using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        List<Contact> address = new List<Contact>();
        public AddressBook()
        {
            Contact address1 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Email = Console.ReadLine(),
                Pincode = Convert.ToInt32(Console.ReadLine()),
                Mobile = Convert.ToInt64(Console.ReadLine()),
            };
            Contact address2 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Email = Console.ReadLine(),
                Pincode = Convert.ToInt32(Console.ReadLine()),
                Mobile = Convert.ToInt64(Console.ReadLine()),
            };
            address.Add(address1);
            address.Add(address2);
        }
        public void AddcontactToAddressbook(Contact contact)
        {
            address.Add(contact);
        }
        public void Display()
        {
            foreach(var contact in address)
            {
                Console.WriteLine(contact.FirstName+" "+contact.LastName+" "+contact.Address+" "+contact.City+" "+contact.State+" "+contact.Email+" "+contact.Pincode+" "+contact.Mobile);
            }
        }
    }
}
