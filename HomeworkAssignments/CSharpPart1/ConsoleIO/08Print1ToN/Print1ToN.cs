using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Print1ToN
{
    class Print1ToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer \"n\" to see all the numbers from 1 to \"n\"");
            // Get value from user input.
            int n = int.Parse(Console.ReadLine());

            // Print all the numbers from 1 to n.
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
