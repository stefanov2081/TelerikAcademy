using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SolveQuadraticEquation
{
    class SolveQuadraticEquation
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Solve quadratic equation ax^2 + bx + c = 0" + "\nEnter \"a\"");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"b\"");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"c\"");
            double c = double.Parse(Console.ReadLine());

            // Find discriminant.
            double d = (b * b) - (4 * a * c);

            // If discriminant is less than zero => there are no real roots.
            if (d < 0)
            {
                Console.WriteLine("There are no real roots.");
            }
            // If discriminant is greater than zero => calculate real roots.
            else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d) / (2 * a));
                double x2 = (-b - Math.Sqrt(d) / (2 * a));
                Console.WriteLine("x = {0:f4}, {1:f4}", x1, x2);
            }
            // All other cases => calculate real roots. (if d = 0, two real roots are equal)
            else
            {
                double x1 = -b / 2 * a;
                Console.WriteLine("x = {0:f4}", x1);
 
            }
        }
    }
}
