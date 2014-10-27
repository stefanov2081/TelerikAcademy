using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063SandGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char asterisk = '*';
            char blank = '.';

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(blank, i));
                Console.Write(new string(asterisk, n - (i * 2)));
                Console.WriteLine(new string(blank, i));
            }
            for (int i = n / 2; i > 0; i--)
            {
                Console.Write(new string(blank, i));
                Console.Write(new string(asterisk, n - (i * 2)));
                Console.WriteLine(new string(blank, i));
            }
            Console.WriteLine(new string(asterisk, n));
        }
    }
}
