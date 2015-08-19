using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem15_AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your date of Birth(dd/mm/yyyy):");
            DateTime age = DateTime.Parse(Console.ReadLine());
            
            if (DateTime.Now.Month < age.Month)
                {
                    Console.WriteLine("You are {0} old", DateTime.Now.Year-age.Year-1);
                    Console.WriteLine("You will be {0} years old after 10 years", DateTime.Now.Year - age.Year -1 + 10);
                }
            else
                {
                    Console.WriteLine("You are {0} old", DateTime.Now.Year-age.Year);
                    Console.WriteLine("You will be {0} years old after 10 years", DateTime.Now.Year - age.Year + 10);
                }   
            
        }
    }
}
