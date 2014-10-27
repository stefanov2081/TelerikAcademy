using System;

class Trapezoid_2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //Top Line
        for (int i = 0; i <= 2 * n - 1; i++)
        {
            if (i >= n)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();

        //essential part
        for (int i = n; i > 1; i--)
        {
            for (int j = 1; j < n * 2; j++)
            {
                if (i != j)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("*");
        }

        //Botton line
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}