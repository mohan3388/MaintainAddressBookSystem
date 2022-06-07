using System;
using AddressBookSystem;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome To address book");
        Console.WriteLine("1.Add contact Details\n2.Edit Contact Details\n3.Delete Contact from addressbook");
        AddressBook addressBook = new AddressBook();

        bool check = true;
        while (check)
        {
            Console.WriteLine("Enter Above option");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    addressBook.Display();
                    break;
                case 2:
                    Console.WriteLine("Enter the first name to edit");
                    string name = Console.ReadLine();
                    addressBook.EditAddress(name);
                    break;
                case 3:
                    Console.WriteLine("enter first name to delete");
                    addressBook.Delete();
                    break;
                case 4:
                    Console.WriteLine("enter name for add data dictionary");
                    string dictionaryName = Console.ReadLine();
                    addressBook.Adddict(dictionaryName);
                    break;
                default:
                    check = false;
                    break;
            }
        }
        }
    }

