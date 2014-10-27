using System;
using System.Net;

namespace _04DownloadFromInternet
{
    class SaveInCurrentDir
    {
        static void Main(string[] args)
        {
            // If no exceptions occur => do this
            try
            {
                // Get value from user input
                Console.Write("Enter web address of a file to download: ");
                string path = Console.ReadLine();
                Console.Write("Save file as? Enter name (enter file extension too): ");
                string name = Console.ReadLine();
                
                // Download file
                using (WebClient web = new WebClient())
                {
                    Console.WriteLine("Connecting to server... please wait...");
                    web.DownloadFile(path, name);
                    Console.WriteLine("File downloaded.");
                }
            }
            // If exceptions occur => catch exceptions
            catch (WebException)
            {
                Console.WriteLine("Error: Invalid URL!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: You don't have permission to read/ write in that location!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error: enter valid URL or filepath!");
            }
        }
    }
}
