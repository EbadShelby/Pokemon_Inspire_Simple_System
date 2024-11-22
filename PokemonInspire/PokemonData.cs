using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInspire
{
    public static class PokemonData
    {
        public static List<Pokemon> pokemonList = new List<Pokemon>
        {
            // Charmander Line
            new Pokemon("Charmander", "Fire", 39, 52, 16, "Charmeleon",
                new List<Attack> {
                    new Attack("Ember", 40),
                    new Attack("Scratch", 35)
                }),
            new Pokemon("Charmeleon", "Fire", 58, 64, 36, "Charizard",
                new List<Attack> {
                    new Attack("Flamethrower", 90),
                    new Attack("Slash", 70)
                }),
            new Pokemon("Charizard", "Fire/Flying", 78, 84, 0, null,
                new List<Attack> {
                    new Attack("Fire Blast", 110),
                    new Attack("Wing Attack", 60)
                }),

            // Bulbasaur Line
            new Pokemon("Bulbasaur", "Grass/Poison", 45, 49, 16, "Ivysaur",
                new List<Attack> {
                    new Attack("Vine Whip", 45),
                    new Attack("Tackle", 35)
                }),
            new Pokemon("Ivysaur", "Grass/Poison", 60, 62, 32, "Venusaur",
                new List<Attack> {
                    new Attack("Razor Leaf", 55),
                    new Attack("Double-Edge", 120)
                }),
            new Pokemon("Venusaur", "Grass/Poison", 80, 82, 0, null,
                new List<Attack> {
                    new Attack("Solar Beam", 120),
                    new Attack("Sludge Bomb", 90)
                }),

            // Squirtle Line
            new Pokemon("Squirtle", "Water", 44, 48, 16, "Wartortle",
                new List<Attack> {
                    new Attack("Water Gun", 40),
                    new Attack("Tackle", 35)
                }),
            new Pokemon("Wartortle", "Water", 59, 63, 36, "Blastoise",
                new List<Attack> {
                    new Attack("Hydro Pump", 110),
                    new Attack("Bite", 60)
                }),
            new Pokemon("Blastoise", "Water", 79, 83, 0, null,
                new List<Attack> {
                    new Attack("Skull Bash", 130),
                    new Attack("Surf", 90)
                }),
        };
    }
}
