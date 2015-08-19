using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 10. Point Inside a Circle & Outside of a Rectangle• Write an expression that checks for given point (x, y)
//if it is within the circle  K({1, 1}, 1.5)  and out of the rectangle  R(top=1, left=-1, width=6, height=2) .
//Examples:
//x
//y
//inside K & outside of R

//1 2 yes 
//2.5 2 no 
//0 1 no 
//2.5 1 no 
//2 0 no 
//4 0 no 
//2.5 1.5 no 
//2 1.5 yes 
//1 2.5 yes 
//-100 -100 no 

namespace Problem10PointInsideACircleAndOutsideOfARectangle
{
    class PointInsideACircleAndOutside
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter point X:");
            double pointX = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Please, enter point Y:");
            double pointY = double.Parse(Console.ReadLine());

            double diameter = Math.Pow((pointX - 1), 2) + Math.Pow((pointY - 1), 2);

             //R(up=1, left=-1, right=5, down=-1) .

            if (( diameter <= 1.5*1.5) && !(pointX<=5 && pointX>=-1 && pointY<=1 && pointY >=-1))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("{0}  {1} YES", pointX, pointY);
                    Console.WriteLine("Given point (x={0}, y={1}) is inside K & ouside of R", pointX, pointY);
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("{0}  {1} NO", pointX, pointY);
                    Console.WriteLine("Given point (x={0}, y={1}) is NOT", pointX, pointY);
                }
       }
    }
 }

