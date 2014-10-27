using System;
using System.Text;

namespace _10ConvertString
{
    class ToUnicode
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            // Append unicode prefix
            StringBuilder inpInUni = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                inpInUni.AppendFormat("\\u{0:x4}", (int)input[i]);
            }

            // Print
            Console.WriteLine("{0} in unicode: {1}", input, inpInUni.ToString());
        }
    }
}
