using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PokemonInspire
{
    public class Attack
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Attack(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}
