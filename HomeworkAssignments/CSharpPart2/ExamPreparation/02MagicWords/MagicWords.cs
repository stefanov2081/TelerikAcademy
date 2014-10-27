using System;
using System.Collections.Generic;
using System.Text;

namespace _02MagicWords
{
    class MagicWords
    {
        static void Reorder(List<string> list, int n)
        {
            int position;
            
            for (int i = 0; i < list.Count; i++)
            {
                position = list[i].Length % (n + 1);
                list.Insert(position, list[i]);

                if (list[i] == list[position])
                {
                    list.RemoveAt(i);
                }
                else
                {
                    list.RemoveAt(i + 1);
                }
            }
        }

        static int GetLongestWord(List<string> list)
        {
            int current;
            int length = 0;

            for (int i = 0; i < list.Count; i++)
            {
                current = list[i].Length;

                if (current > length)
                {
                    length = current;
                }
            }

            return length;
        }

        static void Print(List<string> list)
        {
            StringBuilder sb = new StringBuilder();

            int length = GetLongestWord(list);

            for (int i = 0; i < length; i++)
            {
                foreach (var word in list)
                {
                    if (i < word.Length)
                    {
                        sb.Append(word[i]);
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            Reorder(words, n);
            Print(words);
        }
    }
}
