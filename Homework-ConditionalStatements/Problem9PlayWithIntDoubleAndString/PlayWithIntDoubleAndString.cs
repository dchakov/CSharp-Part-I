//Problem 9. Play with Int, Double and String• Write a program that, depending on the user’s choice, inputs an  int ,  double  or  string  variable.
//◦ If the variable is  int  or  double , the program increases it by one.
//◦ If the variable is a  string , the program appends  *  at the end.
//• Print the result at the console. Use switch statement.
//Example 1:
//program
//user
//Please choose a type:  
//1 --> int  
//2 --> double 3 
//3 --> string  
  //Please enter a string: hello 
  //hello*  
//Example 2:
//program
//user
//Please choose a type:  
//1 --> int  
//2 --> double 2 
//3 --> string  
  //Please enter a double: 1.5 
 //2.5 

using System;
using System.Threading;
using System.Globalization;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int ");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        string digit = Console.ReadLine();

        int number;
        if (int.TryParse(digit, out number))

            if (number == 1)
            {
                Console.WriteLine("Please enter a integer:");
                int result = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(result);
            }
            else if (number == 2)
            {
                Console.WriteLine("Please enter a double:");
                double result = double.Parse(Console.ReadLine()) + 1;
                 Console.WriteLine(result);
            }
         else
        {
            Console.WriteLine("Please enter a string:");
            Console.WriteLine(Console.ReadLine() + "*");
        }
    }
}
