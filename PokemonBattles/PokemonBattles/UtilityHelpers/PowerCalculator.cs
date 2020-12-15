using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonBattles
{
    static class PowerCalculator
    {
        public static int CalculateAttackDamage(Pokemon pokemon)
        {
            Random r = new Random();
            int dmg = r.Next(0, 100);
            return dmg;
        }
    }
}
