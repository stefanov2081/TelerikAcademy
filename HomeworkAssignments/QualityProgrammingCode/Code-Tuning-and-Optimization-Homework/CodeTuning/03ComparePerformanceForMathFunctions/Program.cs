using System;
using System.Diagnostics;

namespace _03ComparePerformanceForMathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            float testFloat = 50.05F;
            double testDouble = 50.05;
            decimal testDecimal = 50.05M;
            int iterations = 100;
            Stopwatch sw = new Stopwatch();

            // Square root
            Console.WriteLine("Square root");
            Console.WriteLine("Float SQRT... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                Math.Sqrt(testFloat);
            }

            sw.Stop();

            Console.Write("Finding the square root of {0}, iterating {1} times took: ", testFloat, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            Console.WriteLine("Double SQRT... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                Math.Sqrt(testDouble);
            }

            sw.Stop();

            Console.Write("Finding the square root of {0}, iterating {1} times took: ", testDouble, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            Console.WriteLine("Decimal SQRT... Please wait...");
            Console.WriteLine("This test is subjective, as Math.Sqrt takes double as argument and decimal has to be casted to double," + 
                " which presumably is a slow operation");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                Math.Sqrt((double)testDecimal);
            }

            sw.Stop();

            Console.Write("Finding the square root of {0}, iterating {1} times took: ", testDouble, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Logarithm
            Console.WriteLine();
            Console.WriteLine("Logarithm");
            Console.WriteLine("Float Log... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                Math.Log(testFloat);
            }

            sw.Stop();

            Console.Write("Finding logarithm of {0}, iterating {1} times took: ", testFloat, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            Console.WriteLine("Double Log... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                Math.Log(testDouble);
            }

            sw.Stop();

            Console.Write("Finding logarithm of {0}, iterating {1} times took: ", testDouble, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            Console.WriteLine("Decimal Log... Please wait...");
            Console.WriteLine("This test is subjective, as Math.Log takes double as argument and decimal has to be casted to double," +
                " which presumably is a slow operation");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                Math.Log((double)testDecimal);
            }

            sw.Stop();

            Console.Write("Finding the logarithm of {0}, iterating {1} times took: ", testDouble, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Sinus
            Console.WriteLine();
            Console.WriteLine("Sinus");
            Console.WriteLine("Float Sin... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                Math.Sin(testFloat);
            }

            sw.Stop();

            Console.Write("Finding sinus of {0}, iterating {1} times took: ", testFloat, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            Console.WriteLine("Double Sin... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                Math.Sin(testDouble);
            }

            sw.Stop();

            Console.Write("Finding sinus of {0}, iterating {1} times took: ", testDouble, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            Console.WriteLine("Decimal Sin... Please wait...");
            Console.WriteLine("This test is subjective, as Math.Log takes double as argument and decimal has to be casted to double," +
                " which presumably is a slow operation");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                Math.Sin((double)testDecimal);
            }

            sw.Stop();

            Console.Write("Finding sinus of {0}, iterating {1} times took: ", testDouble, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);
        }
    }
}
