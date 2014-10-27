using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PerAndAreaOfACircle
{
    class PerAndAreaOfACircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius \"r\" of a cirlce.");
            // Get value from user input.
            double radius = double.Parse(Console.ReadLine());
            // Calculate and print the perimeter of the circle.
            Console.WriteLine("The perimeter of a circle with radius " + radius + " is = " + 
                (2 * radius *  3.14159));
            // Calculate and print the area of the circle.
            Console.WriteLine("The area of a circle with radius " + radius + " is = " + 
                (3.14159 * (radius * radius)));
        }
    }
}
