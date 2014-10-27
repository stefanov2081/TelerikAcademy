using System;
using System.Diagnostics;

namespace _02CompareMathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 1;
            int secondInt = 1;
            long firstLong = 1;
            long secondLong = 1;
            float firstFloat = 0.1F;
            float secondFloat = 0.1F;
            double firstDouble = 0.1;
            double secondDouble = 0.1;
            decimal firstDecimal = 0.1M;
            decimal secondDecimal = 0.1M;
            int iterations = 1000;
            //int iterations = int.MaxValue - 1;
            Stopwatch sw = new Stopwatch();

            // Addition
            Console.WriteLine("Addition");
            Console.WriteLine("Each data type will be added {0} times.", iterations);

            // Int
            Console.WriteLine("Adding integers... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstInt += secondInt;
            }

            sw.Stop();

            Console.Write("Adding {0}, {1} times took: ", secondInt, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Long
            Console.WriteLine("Adding long... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstLong += secondLong;
            }

            sw.Stop();

            Console.Write("Adding {0}, {1} times took: ", secondLong, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Float
            Console.WriteLine("Adding floats... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstFloat += secondFloat;
            }

            sw.Stop();

            Console.Write("Adding {0}, {1} times took: ", secondFloat, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Double
            Console.WriteLine("Adding doubles... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstDouble += secondDouble;
            }

            sw.Stop();

            Console.Write("Adding {0}, {1} times took: ", secondDouble, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Decimal
            Console.WriteLine("Adding decimals... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstDecimal += secondDecimal;
            }

            sw.Stop();

            Console.Write("Adding {0}, {1} times took: ", secondDecimal, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Subtraction
            Console.WriteLine();
            Console.WriteLine("Subtraction");
            Console.WriteLine("Each data type will be subtracted {0} times.", iterations);

            // Int
            Console.WriteLine("Subtracting integers... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstInt -= secondInt;
            }

            sw.Stop();

            Console.Write("Subtracting {0}, {1} times took: ", secondInt, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Long
            Console.WriteLine("Subtracting long... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstLong -= secondLong;
            }

            sw.Stop();

            Console.Write("Subtracting {0}, {1} times took: ", secondLong, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Float
            Console.WriteLine("Subtracting floats... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstFloat -= secondFloat;
            }

            sw.Stop();

            Console.Write("Subtracting {0}, {1} times took: ", secondFloat, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Double
            Console.WriteLine("Subtracting doubles... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstDouble -= secondDouble;
            }

            sw.Stop();

            Console.Write("Subtracting {0}, {1} times took: ", secondDouble, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Decimal
            Console.WriteLine("Subtracting decimals... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstDecimal -= secondDecimal;
            }

            sw.Stop();

            Console.Write("Subtracting {0}, {1} times took: ", secondDecimal, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Multiplication
            Console.WriteLine();
            Console.WriteLine("Multiplication");
            Console.WriteLine("Each data type will be multiplied {0} times.", iterations);

            // Int
            Console.WriteLine("Multiplicating integers... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstInt *= secondInt;
            }

            sw.Stop();

            Console.Write("Multiplicating {0}, {1} times took: ", secondInt, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Long
            Console.WriteLine("Multiplicating long... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstLong *= secondLong;
            }

            sw.Stop();

            Console.Write("Multiplicating {0}, {1} times took: ", secondLong, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Float
            Console.WriteLine("Multiplicating floats... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstFloat *= secondFloat;
            }

            sw.Stop();

            Console.Write("Multiplicating {0}, {1} times took: ", secondFloat, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Double
            Console.WriteLine("Multiplicating doubles... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstDouble *= secondDouble;
            }

            sw.Stop();

            Console.Write("Multiplicating {0}, {1} times took: ", secondDouble, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Decimal
            Console.WriteLine("Multiplicating decimals... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstDecimal *= secondDecimal;
            }

            sw.Stop();

            Console.Write("Multiplicating {0}, {1} times took: ", secondDecimal, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Division
            Console.WriteLine();
            Console.WriteLine("Division");
            Console.WriteLine("Each data type will be divided {0} times.", iterations);

            // Int
            Console.WriteLine("Dividing integers... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstInt /= secondInt;
            }

            sw.Stop();

            Console.Write("Dividing {0}, {1} times took: ", secondInt, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Long
            Console.WriteLine("Dividing long... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstLong /= secondLong;
            }

            sw.Stop();

            Console.Write("Dividing {0}, {1} times took: ", secondLong, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Float
            Console.WriteLine("Dividing floats... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstFloat /= secondFloat;
            }

            sw.Stop();

            Console.Write("Dividing {0}, {1} times took: ", secondFloat, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Double
            Console.WriteLine("Dividing doubles... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstDouble /= secondDouble;
            }

            sw.Stop();

            Console.Write("Dividing {0}, {1} times took: ", secondDouble, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);

            // Decimal
            Console.WriteLine("Dividing decimals... Please wait...");

            sw.Start();

            for (int i = 0; i < iterations; i++)
            {
                firstDecimal /= secondDecimal;
            }

            sw.Stop();

            Console.Write("Dividing {0}, {1} times took: ", secondDecimal, iterations);
            Console.WriteLine("{0} HH:MM:SS:MS", sw.Elapsed);
        }
    }
}
