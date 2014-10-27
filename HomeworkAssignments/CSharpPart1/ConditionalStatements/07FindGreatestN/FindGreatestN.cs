using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07FindGreatestN
{
    class FindGreatestN
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter \"a\"");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"b\"");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"c\"");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"d\"");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"e\"");
            float e = float.Parse(Console.ReadLine());

            // Find which is the greates number.
            float greatestN = Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));

            // Print result.
            Console.WriteLine("The greatest number is {0:f4}", greatestN);
        }
    }
}
