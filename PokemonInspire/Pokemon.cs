using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInspire
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }

        // Constructor for creating a new Pokémon
        public Pokemon(string name, int level, int hp, int attack)
        {
            Name = name;
            Level = level;
            HP = hp;
            Attack = attack;
        }
    }
}
