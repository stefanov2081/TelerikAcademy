using System;

namespace _02TenRandomValues
{
    class TenRandomValues
    {
        static Random randNum = new Random();

        // Generate random number
        static int RandomNum(int a, int b)
        {
            int randomNumber = randNum.Next(a, b);
            return randomNumber;
        }

        static void Main(string[] args)
        {
            // Call RandomNum() and print
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Random number {0}: {1}", i,  RandomNum(100, 201));
            }
        }
    }
}
