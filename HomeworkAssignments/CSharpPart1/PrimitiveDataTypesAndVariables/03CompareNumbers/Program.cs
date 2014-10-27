using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number. Must be of a type \"float\".");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number. Must be of a type \"float\".");
            float b = float.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("The number {0} is greater than {1}", a, b);
            }
            if (a < b)
            {
                Console.WriteLine("The number {0} is smaller than {1}", a, b);
            }
            if (a == b)
            {
                Console.WriteLine("The number {0} is equal to {1}", a, b);
            }
        }
    }
}
