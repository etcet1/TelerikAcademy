using System;

/*A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints them on the console.
 */

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Please enter the following data\nCompany name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Address:");
        string address = Console.ReadLine();
        Console.WriteLine("Phone:");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Website:");
        string website = Console.ReadLine();
        Console.WriteLine("Company manager");
        Console.WriteLine("First name:");
        string companyManagerFirstName = Console.ReadLine();
        Console.WriteLine("Last name:");
        string companyManagerLastName = Console.ReadLine();
        Console.WriteLine("age:");
        int managerAge;
        if(!(int.TryParse(Console.ReadLine(),out managerAge)))
        {
            string inputError = "Invalid data!Please try again";
            Console.WriteLine(inputError);
            return;
        }
        Console.WriteLine("Manager's phone:");
        string companyManagerPhone = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\nCompany:\n{0,25}", companyName);
        Console.WriteLine("Address:\n{0,25}", address);
        Console.WriteLine("Phone:\n{0,25}", phoneNumber);
        Console.WriteLine("Fax:\n{0,25}", faxNumber);
        Console.WriteLine("Website:\n{0,25}", website);
        Console.WriteLine("Manager:\n{0} {1,25}",companyManagerFirstName, companyManagerLastName);
        Console.WriteLine("Age:\n{0,25}", managerAge);
        Console.WriteLine("Manager's phone\n:{0,25}", companyManagerPhone);
    }
}
