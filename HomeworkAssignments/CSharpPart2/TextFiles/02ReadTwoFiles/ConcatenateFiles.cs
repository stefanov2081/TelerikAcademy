using System;
using System.IO;
using System.Text;

namespace _02ReadTwoFiles
{
    class ConcatenateFiles
    {
        static void Main(string[] args)
        {
            // Filepaths
            string filePath1 = @"../../../readFromFile.txt";
            string filePath2 = @"../../../readFromOtherFile.txt";
            string filePathConcatFile = @"../../../concatenatedFile.txt";
            string line;

            // Read two files
            using (StreamReader reader = new StreamReader(filePath1))
            {
                line = reader.ReadToEnd();
                using (StreamReader anotherReader = new StreamReader(filePath2))
                {
                    line += anotherReader.ReadToEnd();
                }
            }

            // Add the two text files to a third one
            using (StreamWriter sw = new StreamWriter(filePathConcatFile))
            {
                sw.Write(line);
            }

            Console.WriteLine("The two files were concatenated in file: " + filePathConcatFile);
        }
    }
}
