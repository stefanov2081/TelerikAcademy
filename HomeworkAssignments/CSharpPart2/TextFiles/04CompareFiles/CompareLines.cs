using System;
using System.IO;

namespace _04CompareFiles
{
    class CompareLines
    {
        static void Main(string[] args)
        {
            // Filepaths
            string filePath1 = @"../../../readFromFile.txt";
            string filePath2 = @"../../../readFromOtherFile.txt";

            int sameLines = 0;
            int differentLines = 0;
            string firstFIle;
            string secondFile;

            // Read two files
            using (StreamReader readFirstFile = new StreamReader(filePath1))
            {
                using (StreamReader readSecondFile = new StreamReader(filePath2))
                {
                    // Read file to the end
                    while ((firstFIle = readFirstFile.ReadLine()) != null)
                    {
                        secondFile = readSecondFile.ReadLine();
                        // Compare each line
                        if (firstFIle == secondFile)
                        {
                            sameLines++;
                        }
                        else
                        {
                            differentLines++;
                        }
                    }
                }
            }

            Console.WriteLine("Same lines: " + sameLines);
            Console.WriteLine("Different lines: " + differentLines);
        }
    }
}
