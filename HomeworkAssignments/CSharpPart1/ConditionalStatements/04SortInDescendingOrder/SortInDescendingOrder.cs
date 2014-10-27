using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SortInDescendingOrder
{
    class SortInDescendingOrder
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter number \"a\"");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number \"b\"");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number \"c\"");
            float c = float.Parse(Console.ReadLine());

            // If a is greater than b and c...
            if (a > b & a > c)
            {
                // ... check if b is greater than c.
                if (b > c)
                {
                    Console.WriteLine(a + ", " + b + ", " + c);
                }
                else
                {
                    Console.WriteLine(a + ", " + c + ", " + b);
                }
            }
            // If b is greater than a and c...
            else if (b > a & b > c)
            {
                // ... check if a is greater than c.
                if (a > c)
                {
                    Console.WriteLine(b + ", " + a + ", " + c);
                }
                else
                {
                    Console.WriteLine(b + ", " + c + ", " + a);
                }
            }
            // If c is greater than a and b...
            else if (c > a & c > b)
            {
                // ... check if a is greate than b.
                if (a > b)
                {
                    Console.WriteLine(c + ", " + a + ", " + b);
                }
                else
                {
                    Console.WriteLine(c + ", " + b + ", " + a);
                }
            }
            // If a is greater than b and a is equal to c.
            else if (a > b & a == c)
            {
                Console.WriteLine(a + ", " + c + ",  " + b);
            }
            // If a is greater than b and b is equal to c.
            else if (a > b & b == c)
            {
                Console.WriteLine(a + ", " + b + ",  " + c);
            }
            // If a is greater than c and a equals b.
            else if (a > c & a == b)
            {
                Console.WriteLine(a + ", " + b + ",  " + c);
            }
            // If b is greater than a and a equals c.
            else if (b > a & a == c)
            {
                Console.WriteLine(b + ", " + a + " ," + c);
            }
            // If c is greater than a and a equals b.
            else if (c > a & a == b)
            {
                Console.WriteLine(c + ", " + b + ", " + a);
            }
            // If c equals b and c is greater than a.
            else if (c == b & c > a)
            {
                Console.WriteLine(c + ", " + b + ", " + a);
            }
            // If c equals b & b is greater than a.
            else if (c == b & b > a)
            {
                Console.WriteLine(c + ", " + b + ", " + a);
            }
            // If a, b and c are equal.
            else
            {
                Console.WriteLine("Maybe I could shuffle the numbers and print them in different order." +
                    "\nHere they are: " + c + ", " + a + ", " + b);
            }
        }
    }
}
