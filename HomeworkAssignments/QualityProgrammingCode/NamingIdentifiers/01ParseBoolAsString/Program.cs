using System;

namespace _01ParseBoolAsString
{
    public class BoolAsString
    {
        const int MaxCount = 6;

        public class PrintBoolAsString
        {
            public void ParseBoolAsStringAndPrint(bool var)
            {
                string varAsString = var.ToString();
                Console.WriteLine(varAsString);
            }
        }

        static void Main(string[] args)
        {
            BoolAsString.PrintBoolAsString newInstance = new BoolAsString.PrintBoolAsString();
            newInstance.ParseBoolAsStringAndPrint(true);

        }
    }
}
