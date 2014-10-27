using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08FindTrapezoidArea
{
    class FindTrapezoidArea
    {
        static void Main(string[] args)
        {
            // Get the values for the trapezoid from user input.
            Console.WriteLine("Enter trapezoid's side \"a\".");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter trapezoid's side \"b\".");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter trapezoid's height \"h\".");
            float h = float.Parse(Console.ReadLine());
            
            // Calculate and print the are of the trapezoid.
            Console.WriteLine("The are of a trapezoid with side \"a\" = " + a + " and side \"b\" = " + b + " and                 height = " + h + " is = " + ((a + b) / 2) * h);
        }
    }
}
