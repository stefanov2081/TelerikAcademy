using System;
using System.IO;
using System.Text;

namespace _03ReadFile
{
    class InsertLineNumbers
    {
        static void Main(string[] args)
        {
            // Filepaths
            string filePath = @"../../../concatenatedFile.txt";
            string outputFilePath = @"../../../concatenatedFileWithLineNumbers.txt";

            string line;
            string text = "";
            int lineNumber = 0;

            // Read from file and add line numbers to each line
            using (StreamReader reader = new StreamReader(filePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        lineNumber++;
                        text = (lineNumber.ToString() + ". ") + line;
                        writer.WriteLine(text);
                        
                    }
                }
            }
            Console.WriteLine("Line numbers added to file: " + outputFilePath);
        }
    }
}
