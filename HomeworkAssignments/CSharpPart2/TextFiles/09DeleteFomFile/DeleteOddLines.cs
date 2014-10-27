using System;
using System.IO;

namespace _09DeleteFomFile
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            // Filepaths
            string inFilepath = @"..\..\..\concatenatedFileWithLineNumbers.txt";
            string outFilepath = @"..\..\..\noOddLines.txt";

            string line;
            int lineNum = 1;

            // Read from file
            using (StreamReader reader = new StreamReader(inFilepath))
            {
                // Write to file each even line
                using (StreamWriter writer = new StreamWriter(outFilepath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (lineNum % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        lineNum++;
                    }
                }
            }

            Console.WriteLine("File written!");
        }
    }
}
