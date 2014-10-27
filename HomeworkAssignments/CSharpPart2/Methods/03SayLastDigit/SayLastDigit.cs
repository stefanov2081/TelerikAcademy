using System;

namespace _03SayLastDigit
{
    class SayLastDigit
    {
        // Get last digit as a string
        static string LastDigit(int a)
        {
            if (a < 0)
            {
                a *= -1;
            }
            string lastDigit;
            a %= 10;
            switch (a)
            {
                case 0:
                    lastDigit = "zero";
                    return lastDigit;
                case 1:
                    lastDigit = "one";
                    return lastDigit;
                case 2:
                    lastDigit = "two";
                    return lastDigit;
                case 3:
                    lastDigit = "three";
                    return lastDigit;
                case 4:
                    lastDigit = "four";
                    return lastDigit;
                case 5:
                    lastDigit = "five";
                    return lastDigit;
                case 6:
                    lastDigit = "six";
                    return lastDigit;
                case 7:
                    lastDigit = "seven";
                    return lastDigit;
                case 8:
                    lastDigit = "eight";
                    return lastDigit;
                    case 9:
                    lastDigit = "nine";
                    return lastDigit;
                default:
                    lastDigit = "Error";
                    return lastDigit;
            }

        }
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());

            // Call LastDigit() and print
            Console.WriteLine("The last digit of {0} is {1}", n, LastDigit(n));
        }
    }
}
