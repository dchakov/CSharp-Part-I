using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

namespace Problem10_EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Ivan";
            string lastName = "Ivanov";
            byte age = 30;
            bool isMale = true;
            ulong personalIdNumber = 8310104567;
            uint uniqueEmployeeNumber = 27560000;
            Console.WriteLine("First Name:" + firstName);
            Console.WriteLine("Last Name:" + lastName);
            Console.WriteLine("Age:" + age);
            if (isMale)
                Console.WriteLine("Gender:Male");
            else
                Console.WriteLine("Gender:Female");
            Console.WriteLine("Personal ID Number:" + personalIdNumber);
            Console.WriteLine("Unique Employee Number:" + uniqueEmployeeNumber);
        }
    }
}
