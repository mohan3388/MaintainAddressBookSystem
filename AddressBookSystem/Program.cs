﻿using System;
using AddressBookSystem;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome To address book");
        Console.WriteLine("1.Add contact Details\n2.Edit Contact Details\n3.Delete Contact from addressbook\n4.Add Data in Dictionary\n5.Edit data in Dictionary\n6.Delete data from dictionary\n7.Search person using Cityname\n8.view person detais using Cityname\n9.Get Phone Number by City\n ");
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
                    string name1 = Console.ReadLine();
                    addressBook.DeleteContactInAddressBook(name1);
                    break;
                case 4:
                    Console.WriteLine("enter name for add data dictionary");
                    string dictionaryName = Console.ReadLine();
                    addressBook.Adddict(dictionaryName);
                    break;
                case 5:
                    Console.WriteLine("enter the name for Edit data");
                    string dictname = Console.ReadLine();
                    string contactName = Console.ReadLine();
                    addressBook.EditDict(dictname, contactName);
                    break;
                case 6:
                    Console.WriteLine("Enter the Dictionary and Name to Delete Dictionary");

                    string deleteName = Console.ReadLine();
                    addressBook.DeleteContactInAddressBook(deleteName);
                    break;
                case 7:
                    Console.WriteLine("Enter the City Name for Search Person City in Dictionary ");
                    string cityName = Console.ReadLine();
                    addressBook.SearchingPersonInCity(cityName);
                    break;
                case 8:
                    Console.WriteLine("Enter city and view persons by city Dictionary ");
                    string city = Console.ReadLine();
                    addressBook.MaintainDictionaryWithCityAndPerson(city); 
                    break;
                case 9:
                    Console.WriteLine("Get Person Phone number by City");
                    
                    string Cityname = Console.ReadLine();
                    addressBook.PhoneNumberByCity(Cityname);
                    break;
                default:
                    check = false;
                    break;
            }
        }
    }
}
