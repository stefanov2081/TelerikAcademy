using System;
using System.IO;
using System.Collections.Generic;

namespace _06ReadStringsFromFile
{
    class SortFile
    {
        // Sort list lexicographically
        static List<string> SortLexicographically(List<string> names)
        {
            // Select first element
            for (int k = 0; k < names.Count; k++)
            {
                // Select next element
                for (int l = k + 1; l < names.Count; l++)
                {
                    string frstName = names[k];
                    string scndName = names[l];

                    // Compare the elements and sort them
                    if (frstName.Length >= scndName.Length)
                    {
                        for (int i = 0; i < scndName.Length; i++)
                        {
                            if (frstName[i] < scndName[i])
                            {
                                names[k] = frstName;
                                names[l] = scndName;
                                break;
                            }
                            else if (frstName[i] > scndName[i])
                            {
                                names[k] = scndName;
                                names[l] = frstName;
                                break;
                            }
                            else if (i == frstName.Length - 1 && frstName[i] == scndName[i])
                            {
                                names[k] = frstName;
                                names[l] = scndName;
                                break;
                            }
                            else if (i == scndName.Length - 1 && frstName[i] == scndName[i])
                            {
                                names[k] = scndName;
                                names[l] = frstName;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < frstName.Length; i++)
                        {
                            if (frstName[i] < scndName[i])
                            {
                                names[k] = frstName;
                                names[l] = scndName;
                                break;
                            }
                            else if (frstName[i] > scndName[i])
                            {
                                names[k] = scndName;
                                names[l] = frstName;
                                break;
                            }
                            else if (i == scndName.Length - 1 && frstName[i] == scndName[i])
                            {
                                names[k] = frstName;
                                names[l] = scndName;
                                break;
                            }
                            else if (i == frstName.Length - 1 && frstName[i] == scndName[i])
                            {
                                names[k] = frstName;
                                names[l] = scndName;
                                break;
                            }
                        }
                    }
                }
            }

            return names;
        }
        static void Main(string[] args)
        {
            // Filepath
            string filepath = @"..\..\..\names.txt";
            string outFilepath = @"..\..\..\sortedNames.txt";

            List<string> names = new List<string>();
            string temp;
            

            // Read from file
            using (StreamReader reader = new StreamReader(filepath))
            {
                // Add names to list
                while ((temp = reader.ReadLine()) != null)
                {
                    names.Add(temp);
                }
            }

            // Call SortLexicographically()
            names = SortLexicographically(names);

            // Write to file
            using (StreamWriter writer = new StreamWriter(outFilepath))
            {
                for (int i = 0; i < names.Count; i++)
                {
                    writer.WriteLine(names[i]);
                }
            }

            Console.WriteLine("File written!");
        }
    }
}
