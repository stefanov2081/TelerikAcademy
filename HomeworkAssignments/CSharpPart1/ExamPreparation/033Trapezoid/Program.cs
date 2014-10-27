using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char blank = '.';
            char asterisk = '*';

            Console.Write(new string(blank, n));
            Console.WriteLine(new string(asterisk, n));

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(blank, n - 1 - i));
                Console.Write(new string(asterisk, 1));
                Console.Write(new string(blank, n - 1 + i));
                Console.WriteLine(new string(asterisk, 1));
            }
            Console.WriteLine(new string(asterisk, n * 2));
        }
    }
}
