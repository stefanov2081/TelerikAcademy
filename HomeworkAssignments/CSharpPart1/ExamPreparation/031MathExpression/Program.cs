using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031MathExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double numerator = (n * n) + (1 / (m * p)) + 1337;
            double denominator = n - (128.523123123 * p);
            double sinus = Math.Sin(Math.Truncate(m % 180));


            double result = (numerator / denominator) + sinus;


            Console.WriteLine("{0:F6}", result);
        }
    }
}
