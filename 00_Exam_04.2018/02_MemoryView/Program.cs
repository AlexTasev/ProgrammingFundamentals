using System;
using System.Collections.Generic;

namespace MemoryView
{
    class Program
    {
        static void Main()
        {
            List<string> words = new List<string>();

            string input = string.Empty;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Visual Studio crash")
                    break;

                input += line;
            }

            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tokens.Length - 5; i++)
            {
                if (tokens[i] == "32656" && tokens[i + 1] == "19759" && tokens[i + 2] == "32763"
                    && tokens[i + 3] == "0" && tokens[i + 5] == "0")
                {
                    string word = string.Empty;
                    int wordLenght = int.Parse(tokens[i + 4]);

                    for (int j = i + 6; j <= i + 6 + wordLenght; j++)
                    {
                        word += (char)int.Parse(tokens[j]);
                    }

                    words.Add(word);
                }
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}       //  100 %
