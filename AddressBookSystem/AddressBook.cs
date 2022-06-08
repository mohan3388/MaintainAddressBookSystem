using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        List<Contact> addBook = new List<Contact>();
        Dictionary<string, List<Contact>> dictName = new Dictionary<string, List<Contact>>();
        Dictionary<string, string> cityPerson = new Dictionary<string, string>();
        string File_Path = "";
        public AddressBook()
        {
            Contact contact1 = new Contact()
            {
                firstName = "mohan",
                lastName = "sahu",
                Address = "green valey",
                City = "bhilai",
                State = "cg",
                Email = "sahu@12gmail.com",
                Zip = 12451,
                Phone = 744551552

            };
            Contact contact2 = new Contact()
            {
                firstName = "rajesh",
                lastName = "sah",
                Address = "green valey",
                City = "bhilai",
                State = "cg",
                Email = "sahu@12gmail.com",
                Zip = 12451,
                Phone = 744551552
            };
            Contact contact3 = new Contact()
            {
                firstName = Console.ReadLine(),
                lastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Email = Console.ReadLine(),
                Zip = Convert.ToInt32(Console.ReadLine()),
                Phone = Convert.ToInt64(Console.ReadLine()),
            };
            addBook.Add(contact1);
            addBook.Add(contact2);
            addBook.Add(contact3);
        }

        internal void Adddict(object dictName)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            foreach (var contact in addBook)
            {
                Console.WriteLine(contact.firstName + " " + contact.lastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.Email + " " + contact.Zip + " " + contact.Phone);
            }
        }
        public void EditAddress(string name)
        {
            foreach (var contact in addBook)
            {
                if (contact.firstName.Equals(name))
                {
                    Console.WriteLine("1.firstname\n 2.lastname\n 3.Address\n 4.City\n 5.State\n 6.email\n 7.zip\n 8.phone");
                    Console.WriteLine("choose any above option To Update");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Type FirstName to Update");
                            contact.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Type LastName to Update");
                            contact.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Type Address to Update");
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Type City to Update");
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Type State to Update");
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Type Email to Update");
                            contact.Email = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Type Zip to Update");
                            contact.Zip = Convert.ToInt32(Console.ReadLine()); break;
                        case 8:
                            Console.WriteLine("Type Mobile to Update");
                            contact.Phone = Convert.ToInt64(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("type correct option");
                            break;
                    }
                }

            }
            Display();
        }

        public void DeleteContactInAddressBook(string name)
        {
            Contact delete = new Contact();
            foreach (var contact in addBook)
            {
                if (contact.firstName.Equals(name))
                {
                    delete = contact;
                }
            }
            addBook.Remove(delete);
            Display();
        }
        public void AddDictionary(string name)
        {
            if (dictName == null)
            {
                dictName.Add(name, addBook);
            }
            if (NameExists(name) == false)
            {
                dictName.Add(name, addBook);
            }

        }
        public void EditDict(string name, string contactName)
        {
            foreach (var data in dictName)
            {
                if (dictName.Keys.Equals(name))
                {
                    addBook = data.Value;
                    EditAddress(contactName);
                }
            }
        }
        public void DeleteDictionaryData(string name)
        {
            foreach (var data in dictName)
            {
                if (data.Key.Equals(name))
                {
                    addBook = data.Value;
                    DeleteContactInAddressBook(name);
                }
            }
            dictName.Remove(name);
        }
        public bool NameExists(string name)
        {
            foreach (var data in dictName.Keys)
            {
                if (data.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        public void SearchingPersonInCity(string cityName)
        {
            foreach (var contact in addBook)
            {
                if (contact.City.Equals(cityName))
                {
                    Console.WriteLine(contact.firstName + " " + contact.lastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.Email + " " + " " + contact.Zip + " " + contact.Phone);
                }

            }
        }
        public void MaintainDictionaryWithCityAndPerson(string cityName)
        {
            cityPerson.Add("Ajay", "Basti");
            cityPerson.Add("Vijay", "Basti");
            cityPerson.Add("Raj", "Lucknow");
            cityPerson.Add("Ritesh", "Allahabad");
            cityPerson.Add("Aman", "Basti");
            cityPerson.Add("Anuragh", "Banaras");
            foreach (var contact in cityPerson)
            {
                if (contact.Value.Equals(cityName))
                {
                    Console.WriteLine(contact.Key + " " + contact.Value);
                }
            }
        }
        public void PhoneNumberByCity(string cityName)
        {
            foreach (var contact in addBook)
            {
                if (contact.City.Equals(cityName))
                {
                    Console.WriteLine("Mobile Number is" + contact.Phone);
                }
            }
        }
        public void SortPersonName()
        {
            var result = addBook.OrderBy(x => x.firstName).ToList();
            foreach (var contact in result)
            {
                Console.WriteLine(contact.firstName + " " + contact.lastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.Email + " " + " " + contact.Zip + " " + contact.Phone);

            }
        }
        public void SortCityAndState()
        {
            var result = this.addBook.OrderBy(x => x.City).ToList();
            foreach (var contact in result)
            {
                Console.WriteLine(contact.firstName + " " + contact.lastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.Email + " " + " " + contact.Zip + " " + contact.Phone);


            }
        }
        public void ReadIOFile()
        {
            if (File.Exists(FILE_PATH))
            {
                StreamReader read = new StreamReader(FILE_PATH);
                try
                {
                    string s = "";
                    while ((s = read.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}