using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04KaspichaniaBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char blank = '.';
            char asterisk = '*';

            Console.Write(new string(blank, n));
            Console.Write(new string(asterisk, 1));
            Console.WriteLine(new string(blank, n));

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(blank, n - i - 1));
                Console.Write(new string(asterisk, 1));
                Console.Write(new string(blank, i));
                Console.Write(new string(asterisk, 1));
                Console.Write(new string(blank, i));
                Console.Write(new string(asterisk, 1));
                Console.WriteLine(new string(blank, n - i - 1));
            }

            Console.WriteLine(new string(asterisk, n * 2 + 1));

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string(blank, i + 1));
                Console.Write(new string(asterisk, 1));
                Console.Write(new string(blank, n - 2 - i));
                Console.Write(new string(asterisk, 1));
                Console.Write(new string (blank, n - 2 - i));
                Console.Write(new string(asterisk, 1));
                Console.WriteLine(new string(blank, i + 1));
            }
            Console.Write(new string(blank, n - n /2));
            Console.Write(new string(asterisk,n));
            Console.WriteLine(new string(blank, n - n / 2));
        }
    }
}
