using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06IsXandYinACircle
{
    class IsXAndYInACircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There is a circle with radius 5. Enter twoo coordinates, to see if the point with that coordninates lays within the circle \nEnter coordinate X.");

            // Get value from user input for x coordinate.
            double x = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter coordinate y.");

            // Get value from user input for y coordinate.
            double y = double.Parse(Console.ReadLine());
            
            // Calculate the position of the point with coordinates x and y.
            double checkResult = Math.Sqrt(x * x + y * y);
            
            // If checkResult is less than 5 => the point is within the circle. (diameter < 5)
            if (checkResult < 5)
            {
                Console.WriteLine("The point lays within the circle.");
            }
            
            // If checkResult is equal to 5 => the point lays on the circumference. (diameter = 5)
            else if (checkResult == 5)
            {
                Console.WriteLine("The point lays on the circumference.");
            }

            // If checkResult is greater than 5 => the point is outside of the circle. (diameter > 5)
            else
            {
                Console.WriteLine("The point lays outside of the circle.");
            }
        }
    }
}
