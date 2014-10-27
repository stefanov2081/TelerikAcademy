using System;

namespace _02FindMax
{
    class FindMax
    {
        // Find largest number
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3 = int.Parse(Console.ReadLine());

            // Call GetMax() and print
            Console.Write("Largest number is: " + GetMax(num1, GetMax(num2, num3)) + "\n");
            
        }
    }
}
