using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long remainder = 0;

            if (b == 2)
            {
                remainder = a % c;
            }
            if (b == 4)
            {
                remainder = a + c;
            }
            if (b == 8)
            {
                remainder = a * c;
            }

            long originalR = remainder;

            if (remainder % 4u == 0)
            {
                Console.WriteLine(remainder / 4u);
            }
            if (remainder % 4u != 0)
            {
                Console.WriteLine(remainder % 4u);
            }
            Console.WriteLine(originalR);
        }
    }
}
