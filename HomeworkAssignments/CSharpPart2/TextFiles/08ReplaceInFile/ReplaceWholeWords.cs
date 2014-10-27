using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _08ReplaceInFile
{
    class ReplaceWholeWords
    {
        static void Main(string[] args)
        {
            // Filepath
            string inFilepath = @"..\..\..\start.txt";
            string outFilepath = @"..\..\..\wholeFinish.txt";
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
                    line = Regex.Replace(text[i], @"\bstart\b", "finish");
                    text[i] = line;
                    writer.WriteLine(text[i]);
                }
            }

            Console.WriteLine("File written!");
        }
    }
}
