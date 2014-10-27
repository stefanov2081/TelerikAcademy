using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081AmericanPie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int numeratorA = a * d + c * b;
            int denominatorA = b * d;
            int numeratorB = c * b + d * a;
            int denominatorB = d * b;
            decimal decimalFraction;
            //Console.WriteLine(numeratorA + "/" + denominatorB);
            //Console.WriteLine(numeratorC + "/" + denominatorD);

            if ((numeratorA >= denominatorA) || (numeratorB >= denominatorB))
            {
                Console.WriteLine(1);
                Console.WriteLine(numeratorB + "/" + denominatorB);
            }
            else
            {
                decimalFraction = (decimal)numeratorA / (decimal)denominatorB;
                Console.WriteLine("{0:F20}", decimalFraction);
                Console.WriteLine(numeratorB + "/" + denominatorB);

            }
        }
    }
}
