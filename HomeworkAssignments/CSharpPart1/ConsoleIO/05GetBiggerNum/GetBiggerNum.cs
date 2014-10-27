using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05GetBiggerNum
{
    class GetBiggerNum
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter integer.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another one, to see which is greater.");
            int b = int.Parse(Console.ReadLine());

            // Find the greater num and print it.
            Console.WriteLine("The greater number is " + Math.Max(a , b));
        }
    }
}
