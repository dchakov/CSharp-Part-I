using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9. Trapezoids• Write an expression that calculates trapezoid's area by given sides  a  and  b  and height  h .
//Examples:
//a
//b
//h
//area

//5 7 12 72 
//2 1 33 49.5 
//8.5 4.3 2.7 17.28 
//100 200 300 45000 
//0.222 0.333 0.555 0.1540125 

namespace Problem9Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter side a:");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter side b:");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter height h:");
            double heightH = double.Parse(Console.ReadLine());
                        
            double trapezodisArea = ((sideA + sideB)*heightH)/2;

            Console.WriteLine("Trapezodi's area is:" + trapezodisArea);
            Console.WriteLine(sideA+" "+ sideB +" "+heightH+" "+trapezodisArea);
        }
    }
}
