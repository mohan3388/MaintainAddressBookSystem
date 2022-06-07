﻿using System;
using AddressBookSystem;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome To address book");
        Console.WriteLine("1.Add contact Details\n2.Edit Contact Details\n3.Delete Contact from addressbook");
        AddressBook address = new AddressBook();

        bool check = true;
        while (check)
        {
            Console.WriteLine("Enter Above option");
            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    address.Display();
                    break;
                case 2:
                    Console.WriteLine("Enter the name for edit");
                    string name = Console.ReadLine();
                    address.EditContactInAddressBook(name);
                    break;
                case 3:
                    Console.WriteLine("Enter the Name for Delete");
                    string firstname = Console.ReadLine();
                    address.DeletingContactINAddressBook(firstname); break;
                default:
                    check = false;
                    break;
            }
        }
    }
}