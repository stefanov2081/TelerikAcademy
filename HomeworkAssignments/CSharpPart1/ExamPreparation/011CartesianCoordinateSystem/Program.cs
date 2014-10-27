using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _011CartesianCoordinateSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());


            if ((x == 0) && (y == 0))
            {
                Console.WriteLine(0);
            }

            if ((x > 0) && (y > 0))
            {
                Console.WriteLine(1);
            }

            if ((x < 0) && (y > 0))
            {
                Console.WriteLine(2);
            }

            if ((x < 0) && (y < 0))
            {
                Console.WriteLine(3);
            }

            if ((x > 0) && (y < 0))
            {
                Console.WriteLine(4);
            }

            if ((x == 0) && (y != 0))
            {
                Console.WriteLine(5);
            }

            if ((x != 0) && (y == 0))
            {
                Console.WriteLine(6);
            }

            
        }
    }
}
