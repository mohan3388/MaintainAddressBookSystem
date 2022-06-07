using System;
using AddressBookSystem;

public class Program
{
    public static void Main(String[] args)
    {
        Contact Addresbook = new Contact();
        Console.WriteLine("Enter details");
        Addresbook.FirstName = Console.ReadLine();
        Addresbook.LastName = Console.ReadLine();
        Addresbook.Address = Console.ReadLine();
        Addresbook.City = Console.ReadLine();
        Addresbook.State = Console.ReadLine();
        Addresbook.Email= Console.ReadLine();
        Addresbook.Pincode = Convert.ToInt32(Console.ReadLine());
        Addresbook.Mobile = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine(Addresbook.FirstName+" "+Addresbook.LastName+" "+Addresbook.Address+" "+Addresbook.City+" "+Addresbook.State+" "+Addresbook.Email+" "+Addresbook.Pincode+" "+Addresbook.Mobile);
    }
}
