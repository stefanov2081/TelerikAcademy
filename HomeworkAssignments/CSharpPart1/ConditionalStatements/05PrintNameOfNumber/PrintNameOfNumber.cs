using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05PrintNameOfNumber
{
    class PrintNameOfNumber
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter integer from 0 to 9, to see it's name. ");
            int caseSwitch = int.Parse(Console.ReadLine());

            // Print number name according to user input.
            switch (caseSwitch)
            {
                case 0:
                    Console.WriteLine("zero ");
                    break;
                case 1:
                    Console.WriteLine("one ");
                    break;
                case 2:
                    Console.WriteLine("two ");
                    break;
                case 3:
                    Console.WriteLine("three ");
                    break;
                case 4:
                    Console.WriteLine("four ");
                    break;
                case 5:
                    Console.WriteLine("five ");
                    break;
                case 6:
                    Console.WriteLine("six ");
                    break;
                case 7:
                    Console.WriteLine("seven ");
                    break;
                case 8:
                    Console.WriteLine("eight ");
                    break;
                case 9:
                    Console.WriteLine("nine ");
                    break;
                default:
                    Console.WriteLine("Integer must be any number from 0 to 9...");
                    break;
            }
        }
    }
}
