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
        public string Type { get; set; }
        public int BaseHP { get; set; }
        public int BaseAttack { get; set; }
        public int EvolutionLevel { get; set; }
        public string EvolvedForm { get; set; }
        public List<Attack> Attacks { get; set; }

        public Pokemon(string name, string type, int baseHP, int baseAttack, int evolutionLevel, string evolvedForm, List<Attack> attacks)
        {
            Name = name;
            Type = type;
            BaseHP = baseHP;
            BaseAttack = baseAttack;
            EvolutionLevel = evolutionLevel;
            EvolvedForm = evolvedForm;
            Attacks = attacks;
        }
    }
}
