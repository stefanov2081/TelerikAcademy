using System;
using System.Text;

namespace _01TRES4Numbers
{
    class Program
    {
        static string ToOctal(ulong input)
        {
            string[] octal = { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

            StringBuilder sb = new StringBuilder();


            if (input == 0)
            {
                return octal[0];
            }

            while (input != 0)
            {
                sb.Insert(0, octal[input % 9]);
                input /= 9;
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());

            Console.WriteLine(ToOctal(input));
        }
    }
}
