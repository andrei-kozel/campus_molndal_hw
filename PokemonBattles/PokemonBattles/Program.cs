using System;
using System.Collections.Generic;

namespace PokemonBattles
{
    class Program
    {
        private static List<Pokemon> listOfPOkemons = new List<Pokemon>();
        private static int fighter = 0;
        static void Main(string[] args)
        {
            SetupSampleData();
            Fight();
        }

        private static void Fight()
        {
            Pokemon fighterOne = ChoosePokemon();
            Pokemon fighterTwo = ChoosePokemon();
            while(fighterOne.CurrentHealth > 0 && fighterTwo.CurrentHealth > 0)
            {
                if (fighter == 0)
                {
                    fighterOne.Attack(fighterTwo);
                    fighter = 1;
                }
                else if (fighter == 1)
                {
                    fighterTwo.Attack(fighterOne);
                    fighter = 0;
                }
            }
            Console.WriteLine();
            ChooseAWinner(fighterOne, fighterTwo);
        }

        private static void ChooseAWinner(Pokemon fighterOne, Pokemon fighterTwo)
        {
            if (fighterOne.CurrentHealth == 0) { Console.WriteLine($"{fighterTwo.Name} is a winner!"); }
            else if (fighterTwo.CurrentHealth == 0) { Console.WriteLine($"{fighterOne.Name} is a winner!"); }
        }

        private static Pokemon ChoosePokemon()
        {
            Random r = new Random();
            int n = r.Next(0, listOfPOkemons.Count);
            return listOfPOkemons[n];
        }


        private static void SetupSampleData()
        {
            Pokemon bulbasaur = new Pokemon("Bulbasaur", "Grass", new List<string> { "Overgrow", "Chlorophyll" }, 125, 23);
            Pokemon charmander = new Pokemon("Charmander", "Fire", new List<string> { "Blaze", "Solar Power" }, 100, 35);
            Pokemon squirtle = new Pokemon("Squirtle", "Water", new List<string> { "Torrent", "Rain Dish" }, 115, 30);

            listOfPOkemons.Add(bulbasaur);
            listOfPOkemons.Add(charmander);
            listOfPOkemons.Add(squirtle);
        }
    }
}
