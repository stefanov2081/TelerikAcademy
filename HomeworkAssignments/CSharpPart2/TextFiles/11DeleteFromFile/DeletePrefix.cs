using System;
using System.IO;

namespace _11DeleteFromFile
{
    class DeletePrefix
    {
        static string DeletePrfx(string line, string prefix)
        {
            string substring;

            // Get prefix of a word
            substring = line.Substring(0, prefix.Length);
            
            // If the prefix is the same as the desired one => delete it
            if (substring == prefix)
            {
                line = line.Replace(prefix, "");
            }
            return line;
        }

        static void Main(string[] args)
        {
            // Filepaths
            string inFilepath = @"..\..\..\testIn.txt";
            string outFilepath = @"..\..\..\testOut.txt";

            string line;

            // Read file
            using (StreamReader reader = new StreamReader(inFilepath))
            {
                // Write file
                using (StreamWriter writer = new StreamWriter(outFilepath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Call DeletePrfx()
                        writer.WriteLine(DeletePrfx(line, "test"));
                    }
                }
            }

            Console.WriteLine("File written!");
        }
    }
}

