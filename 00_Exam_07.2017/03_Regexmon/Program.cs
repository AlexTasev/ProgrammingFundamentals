using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            int round = 1;

            while (true)
            {
                if (round % 2 == 1)      // Didi's turn
                {
                    string didiPattern = @"[^A-Za-z-]+";

                    Regex regex = new Regex(didiPattern);

                    if (regex.IsMatch(text))
                    {
                        Match currentMatch = Regex.Match(text, didiPattern);
                        text = text.Substring(currentMatch.Index + currentMatch.Length);
                        Console.WriteLine(currentMatch);
                    }
                    else
                    {
                        return;
                    }
                }

                else                     // Bojo's turn
                {
                    string bojoPattern = @"[A-Za-z]+-[A-Za-z]+";

                    Regex regex = new Regex(bojoPattern);

                    if (regex.IsMatch(text))
                    {
                        Match currentMatch = Regex.Match(text, bojoPattern);
                        text = text.Substring(currentMatch.Index + currentMatch.Length);
                        Console.WriteLine(currentMatch);
                    }
                    else
                    {
                        return;
                    }
                }

                round++;
            }
        }
    }
}       // 100 %
