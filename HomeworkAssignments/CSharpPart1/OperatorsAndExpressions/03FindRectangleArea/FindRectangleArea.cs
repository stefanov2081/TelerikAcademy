using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FindRectangleArea
{
    class FindRectangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of a rectangle.");

            // Get value for the width of the rectangle from user input.
            float width = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the hight of a rectangle.");

            // Get value for the hight of the rectangle from user input.
            float hight = float.Parse(Console.ReadLine());
            
            // Find the are of the rectangle.
            float area = width * hight;
            Console.WriteLine("The are of a rectangle with width = " + width + " and hight = " + hight + 
                " is = " + area );
        }
    }
}
