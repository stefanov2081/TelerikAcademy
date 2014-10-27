using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09IsXAndYInACircleAndInASquare
{
    class IsXAndYInACircleAndInASquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There is a circle with radius 3 offset with 1 on each axis.\nThere is a square inscribed within the circle.\nEnter twoo coordinates, to see if the point with that coordninates lays\nwithin the circle and within the square. \nEnter coordinate X.");

            // Get values for x and y from user input.
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate Y.");
            double y = double.Parse(Console.ReadLine());

            // Calculate the position of the point with coordinates x and y and translate the circle.
            double checkResult = Math.Sqrt((x -1) * (x -1) + (y -1) * (y - 1));

            // If checkResult is less than 3 => the point lays within the circle. (diameter < 3)
            if (checkResult < 3)
            {
                Console.WriteLine("The point lays within the circle. ");
                
                // Check if it is on the rectangle or inside the rectangle.
                if ((x > -2 && x < 4) && (y > -2 && y < 2))
                {
                    Console.WriteLine("The point lays on the rectangle too.");
                }
                else if ((x > -1 && x < 4) && y == 0)
                {
                    Console.WriteLine("The point lays within the rectangle too.");
                }
            }

            // If checkResult is equal to 3 => the point lays on the circumference. (diameter = 3)
            else if (checkResult == 3)
            {
                Console.WriteLine("The point lays on the circumference.");

                // Check if it is on the rectangle.
                if (x == 4 && y == 1)
                {
                    Console.WriteLine("The point lays on the rectangle too.");
                }
                
            }

            // If checkResult is greater than 3 => the point is outside of the circle. (diameter > 3)
            else if (checkResult > 3)
            {
                Console.WriteLine("The point lays outside of the circle.");

                // Check if it is on the rectangle or inside the rectangle.
                if ((x > -2 && x < 2) && (y > 3 && y < 6))
                {
                    Console.WriteLine("The point lays on the rectangle too.");
                }
                else if (x == 4 && y == 0)
                {
                    Console.WriteLine("The point lays within the rectangle.");
                }
                
            }
            
        }
    }
}
