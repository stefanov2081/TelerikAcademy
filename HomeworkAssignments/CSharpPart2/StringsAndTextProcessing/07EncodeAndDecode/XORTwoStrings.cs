using System;
using System.IO;
using System.Text;

namespace _07EncodeAndDecode
{
    class XORTwoStrings
    {
        // Equalize the lengths of message and cypher
        static string EqualizeLenghts(string mess, string cyph)
        {
            // Prevent null reference errors
            if (mess != null)
            {
                // Add cypher to cypher
                while (cyph.Length < mess.Length)
                {
                    cyph += cyph;
                }
            }

            return cyph;
        }

        // Encode the message and decode the message
        static string EncodeDecode(string mess, string cyph)
        {
            string encodedMess = "";
            char currentChar;

            // Prevent null reference errors
            if (mess != null)
            {
                // XOR each letter
                for (int i = 0; i < mess.Length; i++)
                {
                    currentChar = (char)(mess[i] ^ cyph[i]);
                    encodedMess += currentChar;
                }
            }

            return encodedMess;
        }

        static void Main(string[] args)
        {
            char a = (char)32;
            Console.WriteLine(a);
            // Get value from user input
            Console.Write("Write a message to encode:");
            string message = Console.ReadLine();
            Console.Write("Enter cypher:");
            string cypher = Console.ReadLine();
            
            // Call EqualizeLenghts()
            cypher = EqualizeLenghts(message, cypher);

            // Call EncodeDecode()
            string encodedMessage = EncodeDecode(message, cypher);

            // Print encodede message
            Console.WriteLine("This is the encoded message:" + encodedMessage + "</END>" + 
                "\n</END> points to the end of the message, for it may end with whitespace");

            // Call EncodeDecode()
            string decodedMessage = EncodeDecode(encodedMessage, cypher);

            // Print decoded message
            Console.WriteLine("This is the original message after it has been decoded:\n" + decodedMessage);
        }
    }
}
