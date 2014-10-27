using System;
using System.IO;
using System.Collections.Generic;

namespace _07ReplaceInFile
{
    class ReplaceStartWithFinish
    {
        static void Main(string[] args)
        {
            // Filepath
            string inFilepath = @"..\..\..\start.txt";
            string outFilepath = @"..\..\..\finish.txt";
            List<string> text = new List<string>();
            string line;

            // Read each line from a file and add it to list
            using (StreamReader reader = new StreamReader(inFilepath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    text.Add(line);
                }
            }

            // Replace every occurrence of start with finish and write it to a file
            using (StreamWriter writer = new StreamWriter(outFilepath))
            {
                for (int i = 0; i < text.Count; i++)
                {
                    text[i] = text[i].Replace("start", "finish");
                    writer.WriteLine(text[i]);
                }
            }

            Console.WriteLine("File written!");
        }
    }
}
