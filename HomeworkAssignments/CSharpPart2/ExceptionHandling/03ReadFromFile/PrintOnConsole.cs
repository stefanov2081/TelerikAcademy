using System;
using System.IO;

namespace _03ReadFromFile
{
    class PrintOnConsole
    {
        // Read from file
        static string ReadFile(string path)
        {
            string content;

            // If the file exists => read all from the file else throw exception
            if (File.Exists(path))
            {
                content = File.ReadAllText(path);
            }
            else
            {
                throw new IOException("Error: Invalid filepath or directory/ file missing!");
            }

            return content;
        }

        static void Main(string[] args)
        {
            // If no exceptions occur => do this
            try
            {
                // Get value from user input
                Console.Write("To open a file enter filepath: ");
                string filepath = Console.ReadLine();
                Console.WriteLine(new string('_', 80));
                Console.WriteLine(ReadFile(filepath));
            }
            // If exceptions occur => catch exceptions
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
