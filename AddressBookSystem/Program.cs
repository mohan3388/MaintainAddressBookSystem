using System;
using AddressBookSystem;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome To address book");
        AddressBook address = new AddressBook();
        bool check = true;
        while(check)
        {
            Console.WriteLine("Enter Above option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    address.Display();
                    break;
                default:
                    check = false;
                    break;
            }
        }
    }
}
