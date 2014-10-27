using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PrintNumFromSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            do
            {
                double b = Math.Pow(-1, a + 1) * (a + 1);
                Console.WriteLine(b);
                a++;
            }
            while (a < 11);
        }
    }
}
