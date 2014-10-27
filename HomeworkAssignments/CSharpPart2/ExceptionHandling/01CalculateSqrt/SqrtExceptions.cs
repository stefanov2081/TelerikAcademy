using System;

namespace _01CalculateSqrt
{
    class SqrtExceptions
    {
        static void Main(string[] args)
        {
            // If no exceptions occur => do this
            try
            {
                // Get value from user input
                Console.Write("Enter integer: ");
                int n = int.Parse(Console.ReadLine());

                // If the number is negative => throw exception
                if (n < 0)
                {
                    throw new ArgumentException("Invalid number!");
                }
                // Else find square root and print
                else
                {
                    Console.WriteLine(Math.Sqrt(n));
                }
            }
            // If exceptions occur => catch exceptions
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
            // Print goodbye
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
