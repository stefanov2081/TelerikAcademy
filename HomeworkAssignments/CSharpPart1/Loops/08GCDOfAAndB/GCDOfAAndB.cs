using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08GCDOfAAndB
{
    class GCDOfAAndB
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer \"a\" to find Greatest Common Divider of \"a\" and \"b\".");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer \"b\" to find Greatest Common Divider of \"a\" and \"b\".");
            int b = int.Parse(Console.ReadLine());
            int c;
            int originalA = a;
            int originalB = b;

            if (a > b)
            {
                while (true)
                {
                    c = a % b;
                    if (c == 0)
                    {
                        Console.WriteLine("Greatest Common Divisor for {0} and {1} is {2}", 
                            originalA, originalB, b);
                        break;
                    }
                    a = b % c;
                    if (a == 0)
                    {
                        Console.WriteLine("Greatest Common Divisor for {0} and {1} is {2}",
                            originalA, originalB, c);
                        break;
                    }
                    b = c % a;
                    if (b == 0)
                    {
                        Console.WriteLine("Greatest Common Divisor for {0} and {1} is {2}",
                            originalA, originalB, a);
                        break;
                    }
                }
            }
            else
            {
                while (true)
                {
                    c = b % a;
                    if (c == 0)
                    {
                        Console.WriteLine("Greatest Common Divisor for {0} and {1} is {2}",
                            originalA, originalB, a);
                        break;
                    }
                    b = a % c;
                    if (b == 0)
                    {
                        Console.WriteLine("Greatest Common Divisor for {0} and {1} is {2}",
                            originalA, originalB, c);
                        break;
                    }
                    a = c % b;
                    if (a == 0)
                    {
                        Console.WriteLine("Greatest Common Divisor for {0} and {1} is {2}",
                            originalA, originalB, b);
                        break;
                    }
                }
            }
        }
    }
}
