using System;

namespace _11ReadANumber
{
    class DifferentFormatting
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter number:");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Decimal: " + input.ToString("D15"));
            Console.WriteLine("Hexadecimal: " + input.ToString("X15"));
            Console.WriteLine("Percentage: " + input.ToString("P15"));
            Console.WriteLine("Scientific notation: " + input.ToString("E15"));
        }
    }
}
