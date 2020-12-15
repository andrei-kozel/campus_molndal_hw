using System;
using System.Collections.Generic;

namespace PokemonBattles
{
    class Pokemon
    {
        private string name;
        private string type;
        private List<string> abilities = new List<string>();
        private int maxDmg;
        private int currentHealth;
        private int maxHealth;

        public Pokemon() { }

        public Pokemon(string name, string type, List<string> abilities, int health, int dmg)
        {
            this.Name = name;
            this.Type = type;
            this.Abilities = abilities;
            this.maxHealth = health;
            this.currentHealth = health;
            this.MaxDmg = dmg; 
        }

        public string Name { get => name; set => name = value; }

        public void Attack(Pokemon fighterTwo)
        {
            int damage = PowerCalculator.CalculateAttackDamage(this);
            string ability = ChooseAbility();
            Console.WriteLine($"{Name} attacks {fighterTwo.Name} with [{damage}] dmg using \"{ability}\" ability");
            fighterTwo.CurrentHealth = fighterTwo.CurrentHealth - damage;
            if(fighterTwo.CurrentHealth < 0) { fighterTwo.CurrentHealth = 0; }
            Console.WriteLine($"{fighterTwo.Name} now has [{fighterTwo.CurrentHealth}/{fighterTwo.MaxHealth}]hp");
            Console.WriteLine("===========================");
        }

        private string ChooseAbility()
        {
            Random r = new Random();
            int n = r.Next(0, abilities.Count);
            return abilities[n];
        }


        public string Type { get => type; set => type = value; }
        public List<string> Abilities { get => abilities; set => abilities = value; }
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }
        public int MaxDmg { get => maxDmg; set => maxDmg = value; }
        public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    }

}
