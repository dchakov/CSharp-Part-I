using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 7. Point in a Circle• Write an expression that checks if given point (x, y) is inside a circle  K({0, 0}, 2) .
//Examples:
//xy
//inside

//0 1 true 
//-2 0 true 
//-1 2 false 
//1.5 -1 true 
//-1.5 -1.5 false 
//100 -30 false 
//0 0 true 
//0.2 -0.8 true 
//0.9 -1.93 false 
//1 1.655 true 

namespace Problem7PointIinACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter point X:");
            double pointX = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter point Y:");
            double pointY = double.Parse(Console.ReadLine());

            // Pythagorean theorem a2+b2=c2

            double squareRoot = Math.Sqrt(Math.Abs(pointX * pointX) + Math.Abs(pointY * pointY));

            if (squareRoot<=5)
            {
                Console.WriteLine("\n");
                Console.WriteLine("{0}  {1} TRUE",pointX,pointY);
                Console.WriteLine("Given point (x={0}, y={1}) is inside a circle  K({{0, 0}}, 2)", pointX, pointY);
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("{0}  {1} FALSE",pointX,pointY);
                Console.WriteLine("Given point (x={0}, y={1}) is  NOT inside a circle  K({{0, 0}}, 2)", pointX, pointY);
            }
        }
    }
}
