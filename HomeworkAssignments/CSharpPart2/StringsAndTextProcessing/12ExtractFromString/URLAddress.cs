using System;

namespace _12ExtractFromString
{
    class URLAddress
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter URL: ");
            string url = Console.ReadLine();

            // Get protocl
            int index = url.IndexOf(':');
            string protocol = url.Substring(0, index);

            // Get server
            index = url.IndexOf('/') + 2;
            int closingIndex = url.IndexOf('/', index);
            int length = closingIndex - index;
            string server = url.Substring(index, length);

            // Get resource
            string resource = url.Substring(closingIndex);

            Console.WriteLine("Protocol: " + protocol);
            Console.WriteLine("Server: " + server);
            Console.WriteLine("Resource: " + resource);

        }
    }
}
