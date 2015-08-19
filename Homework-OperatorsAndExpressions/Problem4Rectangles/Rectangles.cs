using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Problem 4. Rectangles• Write an expression that calculates rectangle’s perimeter and area by given width and height.

//Examples:
//width
//height
//perimeter
//area

//3 4 14 12 
//2.5 3 11 7.5 
//5 5 20 25 

namespace Problem4Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter height:");
            double height = double.Parse(Console.ReadLine());

            double rectanglesPerimeter = (width + height) * 2;
            double rectanglesArea = width * height;

            Console.WriteLine("Rectangle's perimeter is:" + rectanglesPerimeter);
            Console.WriteLine("Rectangle's area is:" + rectanglesArea);
        }
    }
}
