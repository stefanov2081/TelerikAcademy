using System;
using System.Collections.Generic;
using System.IO;

namespace _12RemoveFromFile
{
    class ListedWords
    {
        static void Main(string[] args)
        {
            // Filepaths
            string mainFilepath = @"..\..\..\removeWords.txt";
            string listFilepath = @"..\..\..\wordsList.txt";
            string outFilepath = @"..\..\..\removedWordsFromFile.txt";

            List<string> wordsList = new List<string>();
            string text;
            string wordToRemove;

            // Catch exceptions
            try
            {
                // Read main text from file
                using (StreamReader readList = new StreamReader(listFilepath))
                {
                    while ((text = readList.ReadLine()) != null)
                    {
                        wordsList.Add(text);
                    }
                }

                // Read list with words to replace in main file and save it in different file (to be neater)
                using (StreamReader readFile = new StreamReader(mainFilepath))
                {
                    // Write to new file
                    using (StreamWriter writer = new StreamWriter(outFilepath))
                    {
                        text = readFile.ReadToEnd();
                        // Replace everry occurence of words in main text that are listed in wordsList
                        for (int i = 0; i < wordsList.Count; i++)
                        {
                            wordToRemove = wordsList[i];
                            text = text.Replace(wordToRemove, "");
                        }
                        writer.Write(text);
                    }
                }
                Console.WriteLine("File written!");
            }
            catch (IOException)
            {
                Console.WriteLine("Error: Incorrect directory or filepath, or missing file!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Index ouf range!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: You don't have permission to read/ write in that location!");
            }
        }
    }
}
