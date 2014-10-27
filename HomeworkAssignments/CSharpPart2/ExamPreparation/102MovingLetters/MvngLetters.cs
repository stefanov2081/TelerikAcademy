using System;
using System.Text;

namespace _102MovingLetters
{
    class MvngLetters
    {
        static StringBuilder sb = new StringBuilder();

        // Move letters according to Nakov's shenanigans
        static string MoveLetters(StringBuilder concatLett)
        {
            int position;

            // Move letters
            for (int i = 0; i < concatLett.Length; i++)
            {
                char currentChar = concatLett[i];
                position = char.ToLower(currentChar) - 'a' + 1;
                int nextPos = (i + position) % concatLett.Length;

                sb.Remove(i, 1);
                sb.Insert(nextPos, currentChar);
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string[] splittedInput = Console.ReadLine().Split();

            int longestWord = 0;

            for (int i = 0; i < splittedInput.Length; i++)
            {
                if (splittedInput[i].Length > longestWord)
                {
                    longestWord = splittedInput[i].Length;
                }
            }

            for (int i = 0; i < longestWord; i++)
            {
                for (int j = 0; j < splittedInput.Length; j++)
                {
                    string currentWord = splittedInput[j];
                    

                    if (i < currentWord.Length)
                    {
                        int lastLetter = currentWord.Length - 1 - i;
                        sb.Append(currentWord[lastLetter]);
                    }
                }
             }

            string result = MoveLetters(sb);

            Console.WriteLine(result);
        }
    }
}
