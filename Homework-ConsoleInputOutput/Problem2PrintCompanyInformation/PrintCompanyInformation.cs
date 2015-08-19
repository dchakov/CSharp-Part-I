//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:
//program	user
//Company name:	Telerik Academy
//Company address:	31 Al. Malinov, Sofia
//Phone number:	+359 888 55 55 555
//Fax number:	2
//Web site:	http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	25
//Manager phone:	+359 2 981 981
//Example output:

//Telerik Academy
//Address: 231 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981) 

using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name:");
            string companyName = Console.ReadLine();
            Console.Write("Company address:");
            string companyAdress = Console.ReadLine();
            Console.Write("Phone number:");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number:");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site:");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name:");
            string managerFirst = Console.ReadLine();
            Console.Write("Manager last name:");
            string managerLast = Console.ReadLine();
            Console.Write("Manager age:");
            string manageAge = Console.ReadLine();
            Console.Write("Manager phone:");
            string managerPhone = Console.ReadLine();

            Console.WriteLine('\n');
            Console.WriteLine(companyName);
            Console.WriteLine("Addres:" + companyAdress);
            Console.WriteLine("Tel." +phoneNumber);

            int number;
            if (int.TryParse(faxNumber, out number))
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine(faxNumber);
            }

            Console.WriteLine("Web site:" + webSite);
            Console.WriteLine("Manager:{0} {1} (age: {2}, tel. {3})", managerFirst, managerLast, manageAge, managerPhone);

        }
    }

