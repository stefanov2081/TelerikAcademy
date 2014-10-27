using System;
using System.IO;
using System.Collections.Generic;

namespace _13ReadListOfWordsFromFile
{
    class SortByOccurrence
    {
        // Count occurrences of each word
        static int[] Occurrences(List<string> list, string[] mainText)
        {
            int[] occurrences = new int[list.Count];
            string currentWord;

            for (int i = 0; i < list.Count; i++)
            {
                currentWord = list[i];
                for (int j = 0; j < mainText.Length; j++)
                {
                    if (currentWord == mainText[j])
                    {
                        occurrences[i]++;
                    }
                }
            }

            return occurrences;
        }

        // Sort words by occurrences
        static void Sort(List<string> list, int[] occ)
        {
            int swapIndices;
            string swapWords;

            for (int i = 0; i < occ.Length; i++)
            {
                for (int j = i + 1; j < occ.Length; j++)
                {
                    if (occ[j] > occ[i])
                    {
                        // Swap indices
                        swapIndices = occ[i];
                        occ[i] = occ[j];
                        occ[j] = swapIndices;

                        // Swap words
                        swapWords = list[i];
                        list[i] = list[j];
                        list[j] = swapWords;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Filepaths
            string wordsFilepath = @"..\..\..\words.txt";
            string testFilepath = @"..\..\..\test.txt";
            string resultFilepath = @"..\..\..\result.txt";

            List<string> wordsList = new List<string>();
            string[] mainText;
            string text;

            try
            {
                // Read words to count from file
                using (StreamReader readWords = new StreamReader(wordsFilepath))
                {
                    while ((text = readWords.ReadLine()) != null)
                    {
                        wordsList.Add(text);
                    }

                    // Read main text from file and put each word in array
                    using (StreamReader readTest = new StreamReader(testFilepath))
                    {
                        mainText = readTest.ReadToEnd().Split();
                    }

                    // Call Occurrences() and Sort()
                    Sort(wordsList, Occurrences(wordsList, mainText));

                    // Write the result to a file
                    using (StreamWriter writer = new StreamWriter(resultFilepath))
                    {
                        int[] occurrence = Occurrences(wordsList, mainText);
                        for (int i = 0; i < wordsList.Count; i++)
                        {
                            writer.WriteLine(wordsList[i] + " occurs " + occurrence[i].ToString() + " times.");
                        }
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
            catch (Exception)
            {
                Console.WriteLine("Error: Error!");
            }
        }
    }
}
