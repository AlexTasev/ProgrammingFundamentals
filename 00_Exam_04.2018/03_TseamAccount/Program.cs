using System;
using System.Collections.Generic;

namespace _03_TseamAccount_0418
{
    class Program
    {
        static void Main()
        {
            string[] firstGames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<string> account = new List<string>();

            for (int i = 0; i < firstGames.Length; i++)
            {
                account.Add(firstGames[i]);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Play!")
                    break;

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string game = tokens[1];

                switch (command)
                {
                    case "Install":
                        if (account.Contains(game) == false)
                            account.Add(game);
                        break;

                    case "Uninstall":
                        account.Remove(game);
                        break;

                    case "Update":
                        UpdateGame(account, game);
                        break;

                    case "Expansion":
                        ExpansionOfGame(account, game);
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", account));
        }

        private static void ExpansionOfGame(List<string> account, string game)
        {
            string[] expansion = game.Split('-');
            string oldGame = expansion[0];
            string newGame = expansion[1];

            if (account.Contains(oldGame))
            {
                int index = account.IndexOf(oldGame);
                string expanded = oldGame + ":" + newGame;
                account.Insert(index + 1, expanded);
            }
        }

        private static void UpdateGame(List<string> account, string game)
        {
            if (account.Contains(game))
            {
                int index = account.IndexOf(game);
                account.RemoveAt(index);
                account.Add(game);
            }
        }
    }
}       //  100 %
