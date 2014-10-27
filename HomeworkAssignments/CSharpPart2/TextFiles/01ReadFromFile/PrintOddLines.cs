using System;
using System.IO;

namespace _01ReadFromFile
{
    class PrintOddLines
    {
        static void Main(string[] args)
        {
            string line;
            // Use stream reader
            using (StreamReader reader = new StreamReader(@"../../../readFromFile.txt"))
            {
                int i = 1;
                // Read each line from file
                while ((line = reader.ReadLine()) != null)
                {
                    // If line number is odd => print on the console
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    i++;
                }
            }

            
        }
    }
}
