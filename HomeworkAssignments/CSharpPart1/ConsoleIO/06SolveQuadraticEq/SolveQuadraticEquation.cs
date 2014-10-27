using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SolveQuadraticEq
{
    class SolveQuadraticEquation
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Solve quadratic equation ax^2 + bx + c = 0" + "\nEnter a");
            double a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter b.");
            double b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter c.");
            double c = float.Parse(Console.ReadLine());

            // Find discriminant.
            double d = (b * b) - (4 * a * c);

            // If discriminant is less than zero => there are no real roots.
            if (d < 0)
            {
                Console.WriteLine("The equation has no real roots.");
            }

            // If discriminant is greater than zero => find and print real roots.
            else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x = {0:f4}, {1:f4}", x1, x2);
            }

            // If discriminant is equal to zero => find and print real roots.
            else
            {
                double x3 = -b / 2 * a;
                Console.WriteLine("x = {0:f4}", x3);
            }
        }
    }
}
