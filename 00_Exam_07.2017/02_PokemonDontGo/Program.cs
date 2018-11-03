using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main()
        {
            List<int> pokemonList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (true)
            {
                if (pokemonList.Count <= 0)
                {
                    break;
                }

                int index = int.Parse(Console.ReadLine());

                int element = 0;

                if (index >= 0 && index < pokemonList.Count)
                {
                    element = pokemonList[index];
                    sum += element;
                    pokemonList.RemoveAt(index);
                }

                else if (index < 0)
                {
                    element = pokemonList[0];
                    pokemonList.RemoveAt(0);
                    pokemonList.Insert(0, pokemonList[pokemonList.Count - 1]);
                    sum += element;
                }

                else if (index > pokemonList.Count - 1)
                {
                    element = pokemonList[pokemonList.Count - 1];
                    pokemonList.RemoveAt(pokemonList.Count - 1);
                    pokemonList.Add(pokemonList[0]);
                    sum += element;
                }

                for (int i = 0; i < pokemonList.Count; i++)
                {
                    if (pokemonList[i] <= element)
                    {
                        pokemonList[i] += element;
                    }

                    else
                    {
                        pokemonList[i] -= element;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}       // 100 %

