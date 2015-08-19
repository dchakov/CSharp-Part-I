using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

namespace Problem11_BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Ivan";
            string middleName = "Nikolov";
            string lastName = "Ivanov";
            decimal balance = 1256.65m;
            string bankName = "Unicredit";
            string ibanNumber = "BG29NWBK60161331926819";
            ulong creditCardNumberOne = 1234567812345678;
            ulong creditCardNumberSecond = 1234567812345678;
            ulong creditCardNumberThird = 1234567812345678;
            Console.WriteLine("First Name:" + firstName);
            Console.WriteLine("Middle Name:" + middleName);
            Console.WriteLine("Last Name:" + lastName);
            Console.WriteLine("Bank Name:" + bankName);
            Console.WriteLine("Balance:{0:C2}", balance);
            Console.WriteLine("IBAN number:" + ibanNumber);
            Console.WriteLine("Credit Card 1 Number:" + creditCardNumberOne);
            Console.WriteLine("Credit Card 2 Number:" + creditCardNumberSecond);
            Console.WriteLine("Credit Card 3 Number:" + creditCardNumberThird);
            Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
            Console.WriteLine("Currency Symbol: {0}", NumberFormatInfo.CurrentInfo.CurrencySymbol);
        }
    }
}
