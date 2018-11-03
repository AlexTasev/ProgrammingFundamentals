using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MOBAChallenger_0418
{
    class Program
    {
        static void Main()
        {
            var players = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                    break;

                string patternSkills = @" -> ";
                string patternPlayers = @" vs ";
                Regex skilsSplit = new Regex(patternSkills);
                Regex playersSplit = new Regex(patternPlayers);

                if (skilsSplit.IsMatch(input))
                {
                    string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string name = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);

                    FillDictionary(players, name, position, skill);
                }

                else if (playersSplit.IsMatch(input))
                {
                    string[] tokens = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string playerOne = tokens[0];
                    string playerTwo = tokens[1];

                    if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
                    {
                        DuelBetwenPlayers(players, playerOne, playerTwo);
                    }
                }
            }

            foreach (var player in players.OrderByDescending(s => s.Value.Values.Sum()).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }

        private static void FillDictionary(Dictionary<string, Dictionary<string, int>> players,
            string name, string position, int skill)
        {
            if (players.ContainsKey(name) == false)
            {
                players.Add(name, new Dictionary<string, int>());
            }
            if (players[name].ContainsKey(position) == false)
            {
                players[name].Add(position, skill);
            }
            if (players[name][position] < skill)
            {
                players[name][position] = skill;
            }
        }

        private static void DuelBetwenPlayers(Dictionary<string, Dictionary<string, int>> players,
            string playerOne, string playerTwo)
        {
            bool commonPosition = false;

            foreach (var item in players[playerOne])
            {
                if (players[playerTwo].ContainsKey(item.Key))
                {
                    commonPosition = true;
                }
            }

            if (commonPosition)
            {
                int skillPlayerOne = players[playerOne].Values.Sum();
                int skillPlayerTwo = players[playerTwo].Values.Sum();

                if (skillPlayerOne > skillPlayerTwo)
                {
                    players.Remove(playerTwo);
                }
                else if (skillPlayerOne < skillPlayerTwo)
                {
                    players.Remove(playerOne);
                }
            }
        }
    }
}       //  100 %

