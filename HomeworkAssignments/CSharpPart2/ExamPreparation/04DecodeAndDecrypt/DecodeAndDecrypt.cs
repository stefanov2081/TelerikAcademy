using System;
using System.Text;

namespace _04DecodeAndDecrypt
{
    class DecodeAndDecrypt
    {
        static string GetLengthOfCypher(string codedMess)
        {
            string cypher = "";
            char currentChar;

            for (int i = (codedMess.Length - 1); i >= 0; i--)
            {
                currentChar = codedMess[i];
                if (char.IsDigit(currentChar))
                {
                    cypher = currentChar + cypher;
                }
                else
                {
                    return cypher;
                }
            }

            return cypher;
        }

        static string Encode(string input)
        {
            StringBuilder sb = new StringBuilder();
            char currentChar;
            string digit = "";
            int count = 1;

            for (int i = 0; i < input.Length; i++)
            {
                currentChar = input[i];

                if (char.IsDigit(currentChar))
                {
                    digit += (currentChar - 48).ToString();
                }
                else
                {
                    if (digit != string.Empty)
                    {
                        count = int.Parse(digit);
                    }
                    sb.Append(currentChar, count);
                    count = 1;
                    digit = "";
                }
            }

            return sb.ToString();
        }

        static string GetCypher(string input, int cypherLength)
        {
            string cypher = input.Substring((input.Length - cypherLength), cypherLength);
            
            return cypher;
        }

        static string Encrypt(string input, string cypher)
        {
            int steps = Math.Max(input.Length, cypher.Length);
            StringBuilder result = new StringBuilder(input);

            for (int i = 0; i < steps; i++)
            {
                int inputIndex = i % input.Length;
                int cypherIndex = i % cypher.Length;
                result[inputIndex] = (char)(((result[inputIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
            }

            return result.ToString();
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cypherLength = GetLengthOfCypher(input);
            string messWithoutCypherLenght = input.Substring(0, input.Length - cypherLength.Length);
            string decodedMess = Encode(messWithoutCypherLenght);
            string cypher = GetCypher(decodedMess, int.Parse(cypherLength));
            string decryptedMess = decodedMess.Substring(0, decodedMess.Length - cypher.Length);
            string message = Encrypt(decryptedMess, cypher);
            Console.WriteLine(message);
        }
    }
}
