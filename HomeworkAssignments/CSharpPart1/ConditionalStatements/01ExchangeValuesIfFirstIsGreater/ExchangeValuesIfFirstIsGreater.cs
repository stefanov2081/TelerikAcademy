using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValueIfFirstIsGreater
{
    class ExchangeValuesIfFirstIsGreater
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter integer \"a\".");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer \"b\".");
            int b = int.Parse(Console.ReadLine());

            // If a is greater than b exchange their values.
            if (a > b)
            {
                int c;
                c = b;
                b = a;
                a = c;
                Console.WriteLine("If you exchange values, \"a\" = " + a + " and \"b\" = " + b);

            }
            else
            {
                Console.WriteLine("Nothing happens...");
            }
        }
    }
}
