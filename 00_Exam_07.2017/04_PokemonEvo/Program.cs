using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonEvolution_0717
{
    class Program
    {
        static void Main()
        {
            var pokemons = new Dictionary<string, List<Evolution>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "wubbalubbadubdub")
                    break;

                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];

                if (tokens.Length > 1)
                {
                    string evoType = tokens[1];
                    int evoIndex = int.Parse(tokens[2]);

                    Evolution evolution = new Evolution(evoType, evoIndex);

                    if (pokemons.ContainsKey(name) == false)
                    {
                        List<Evolution> currentEvo = new List<Evolution>() { evolution };
                        pokemons.Add(name, currentEvo);
                    }
                    else
                    {
                        pokemons[name].Add(evolution);
                    }
                }

                else
                {
                    if (pokemons.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");

                        foreach (var evo in pokemons[name])
                        {
                            Console.WriteLine($"{evo.EvoType} <-> {evo.EvoIndex}");
                        }
                    }
                }
            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (Evolution evo in pokemon.Value.OrderByDescending(e => e.EvoIndex))
                {
                    Console.WriteLine($"{evo.EvoType} <-> {evo.EvoIndex}");
                }
            }
        }
    }

    class Evolution
    {
        public Evolution(string evoType, int evoIndex)
        {
            EvoType = evoType;
            EvoIndex = evoIndex;
        }

        public string EvoType { get; set; }
        public int EvoIndex { get; set; }
    }
}   //  100 %

