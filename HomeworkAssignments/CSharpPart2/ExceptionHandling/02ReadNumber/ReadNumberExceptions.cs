using System;

namespace _02ReadNumber
{
    class ReadNumberExceptions
    {
        // Read a number
        static int ReadNumber(int start, int end)
        {
            int n = 0;

            n = int.Parse(Console.ReadLine());
            // If the number isn't in the given range => throw exception
            if (n < start || n > end)
            {
                throw new ArgumentException("Error: Enter number between " + start + " - " + end + "!");
            }
            return n;
        }

        static void Main(string[] args)
        {
            // If no exceptions occur => do this
            try
            {
                int start = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Enter number between " + start + " - " + 100);
                    int number = ReadNumber(start, 100);
                    Console.WriteLine("You have entered " + number);
                    start = number;
                }
            }
            // If exceptions occur => catch exceptions
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Enter number!");
            }
        }
    }
}
