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
            // Caterpie Line
            new Pokemon("Caterpie", "Bug", 45, 30, 7, "Metapod",
                new List<Attack> {
                    new Attack("Tackle", 35),
                    new Attack("String Shot", 0)
                }),
            new Pokemon("Metapod", "Bug", 50, 20, 10, "Butterfree",
                new List<Attack> {
                    new Attack("Harden", 0)
                }),
            new Pokemon("Butterfree", "Bug/Flying", 60, 45, 0, null,
                new List<Attack> {
                    new Attack("Confusion", 50),
                    new Attack("Gust", 40)
                }),

            // Weedle Line
            new Pokemon("Weedle", "Bug/Poison", 40, 35, 7, "Kakuna",
                new List<Attack> {
                    new Attack("Poison Sting", 15),
                    new Attack("String Shot", 0)
                }),
            new Pokemon("Kakuna", "Bug/Poison", 45, 25, 10, "Beedrill",
                new List<Attack> {
                    new Attack("Harden", 0)
                }),
            new Pokemon("Beedrill", "Bug/Poison", 65, 90, 0, null,
                new List<Attack> {
                    new Attack("Twineedle", 25),
                    new Attack("Fury Attack", 15)
                }),

            // Pidgey Line
            new Pokemon("Pidgey", "Normal/Flying", 40, 45, 18, "Pidgeotto",
                new List<Attack> {
                    new Attack("Gust", 40),
                    new Attack("Quick Attack", 40)
                }),
            new Pokemon("Pidgeotto", "Normal/Flying", 63, 60, 36, "Pidgeot",
                new List<Attack> {
                    new Attack("Wing Attack", 60),
                    new Attack("Feather Dance", 0)
                }),
            new Pokemon("Pidgeot", "Normal/Flying", 83, 80, 0, null,
                new List<Attack> {
                    new Attack("Air Slash", 75),
                    new Attack("Hurricane", 110)
                }),

            // Rattata Line
            new Pokemon("Rattata", "Normal", 30, 56, 20, "Raticate",
                new List<Attack> {
                    new Attack("Tackle", 35),
                    new Attack("Bite", 60)
                }),
            new Pokemon("Raticate", "Normal", 55, 81, 0, null,
                new List<Attack> {
                    new Attack("Hyper Fang", 80),
                    new Attack("Crunch", 80)
                }),

            // Spearow Line
            new Pokemon("Spearow", "Normal/Flying", 40, 60, 20, "Fearow",
                new List<Attack> {
                    new Attack("Peck", 35),
                    new Attack("Leer", 0)
                }),
            new Pokemon("Fearow", "Normal/Flying", 65, 90, 0, null,
                new List<Attack> {
                    new Attack("Drill Peck", 80),
                    new Attack("Agility", 0)
                }),
            // Ekans Line
            new Pokemon("Ekans", "Poison", 35, 60, 22, "Arbok",
                new List<Attack> {
                    new Attack("Wrap", 15),
                    new Attack("Poison Sting", 15)
                }),
            new Pokemon("Arbok", "Poison", 60, 85, 0, null,
                new List<Attack> {
                    new Attack("Bite", 60),
                    new Attack("Acid", 40)
                }),

            // Pikachu Line
            new Pokemon("Pikachu", "Electric", 35, 55, 22, "Raichu",
                new List<Attack> {
                    new Attack("Thunder Shock", 40),
                    new Attack("Quick Attack", 40)
                }),
            new Pokemon("Raichu", "Electric", 60, 90, 0, null,
                new List<Attack> {
                    new Attack("Thunderbolt", 90),
                    new Attack("Thunder Punch", 75)
                }),

            // Sandshrew Line
            new Pokemon("Sandshrew", "Ground", 50, 75, 22, "Sandslash",
                new List<Attack> {
                    new Attack("Scratch", 35),
                    new Attack("Sand Attack", 0)
                }),
            new Pokemon("Sandslash", "Ground", 75, 100, 0, null,
                new List<Attack> {
                    new Attack("Slash", 70),
                    new Attack("Earthquake", 100)
                }),

            // Nidoran♀ Line
            new Pokemon("Nidoran♀", "Poison", 55, 47, 16, "Nidorina",
                new List<Attack> {
                    new Attack("Scratch", 35),
                    new Attack("Poison Sting", 15)
                }),
            new Pokemon("Nidorina", "Poison", 70, 62, 32, "Nidoqueen",
                new List<Attack> {
                    new Attack("Bite", 60),
                    new Attack("Fury Swipes", 18)
                }),
            new Pokemon("Nidoqueen", "Poison/Ground", 90, 92, 0, null,
                new List<Attack> {
                    new Attack("Earthquake", 100),
                    new Attack("Body Slam", 85)
                }),

            // Nidoran♂ Line
            new Pokemon("Nidoran♂", "Poison", 46, 57, 16, "Nidorino",
                new List<Attack> {
                    new Attack("Peck", 35),
                    new Attack("Poison Sting", 15)
                }),
            new Pokemon("Nidorino", "Poison", 61, 72, 32, "Nidoking",
                new List<Attack> {
                    new Attack("Horn Attack", 65),
                    new Attack("Double Kick", 30)
                }),
            new Pokemon("Nidoking", "Poison/Ground", 81, 102, 0, null,
                new List<Attack> {
                    new Attack("Earthquake", 100),
                    new Attack("Megahorn", 120)
                }),

            // Clefairy Line
            new Pokemon("Clefairy", "Fairy", 70, 45, 18, "Clefable",
                new List<Attack> {
                    new Attack("Pound", 40),
                    new Attack("Sing", 0)
                }),
            new Pokemon("Clefable", "Fairy", 95, 70, 0, null,
                new List<Attack> {
                    new Attack("Moonblast", 95),
                    new Attack("Metronome", 0)
                }),
            // Vulpix Line
            new Pokemon("Vulpix", "Fire", 38, 41, 16, "Ninetales",
                new List<Attack> {
                    new Attack("Ember", 40),
                    new Attack("Quick Attack", 40)
                }),
            new Pokemon("Ninetales", "Fire", 73, 76, 0, null,
                new List<Attack> {
                    new Attack("Flamethrower", 90),
                    new Attack("Confuse Ray", 0)
                }),

            // Jigglypuff Line
            new Pokemon("Jigglypuff", "Normal/Fairy", 115, 45, 18, "Wigglytuff",
                new List<Attack> {
                    new Attack("Pound", 40),
                    new Attack("Sing", 0)
                }),
            new Pokemon("Wigglytuff", "Normal/Fairy", 140, 70, 0, null,
                new List<Attack> {
                    new Attack("Hyper Voice", 90),
                    new Attack("Dazzling Gleam", 80)
                }),

            // Zubat Line
            new Pokemon("Zubat", "Poison/Flying", 40, 45, 22, "Golbat",
                new List<Attack> {
                    new Attack("Bite", 60),
                    new Attack("Wing Attack", 60)
                }),
            new Pokemon("Golbat", "Poison/Flying", 75, 80, 0, null,
                new List<Attack> {
                    new Attack("Air Slash", 75),
                    new Attack("Poison Fang", 50)
                }),

            // Oddish Line
            new Pokemon("Oddish", "Grass/Poison", 45, 50, 21, "Gloom",
                new List<Attack> {
                    new Attack("Absorb", 20),
                    new Attack("Acid", 40)
                }),
            new Pokemon("Gloom", "Grass/Poison", 60, 65, 32, "Vileplume",
                new List<Attack> {
                    new Attack("Stun Spore", 0),
                    new Attack("Sludge Bomb", 90)
                }),
            new Pokemon("Vileplume", "Grass/Poison", 75, 80, 0, null,
                new List<Attack> {
                    new Attack("Solar Beam", 120),
                    new Attack("Petal Dance", 120)
                }),

            // Paras Line
            new Pokemon("Paras", "Bug/Grass", 35, 70, 24, "Parasect",
                new List<Attack> {
                    new Attack("Scratch", 35),
                    new Attack("Stun Spore", 0)
                }),
            new Pokemon("Parasect", "Bug/Grass", 60, 95, 0, null,
                new List<Attack> {
                    new Attack("Spore", 0),
                    new Attack("Giga Drain", 75)
                }),

            // Venonat Line
            new Pokemon("Venonat", "Bug/Poison", 60, 55, 31, "Venomoth",
                new List<Attack> {
                    new Attack("Tackle", 35),
                    new Attack("Psybeam", 65)
                }),
            new Pokemon("Venomoth", "Bug/Poison", 70, 90, 0, null,
                new List<Attack> {
                    new Attack("Bug Buzz", 90),
                    new Attack("Sludge Bomb", 90)
                }),

            // Diglett Line
            new Pokemon("Diglett", "Ground", 10, 55, 26, "Dugtrio",
                new List<Attack> {
                    new Attack("Scratch", 35),
                    new Attack("Mud-Slap", 20)
                }),
            new Pokemon("Dugtrio", "Ground", 35, 100, 0, null,
                new List<Attack> {
                    new Attack("Earthquake", 100),
                    new Attack("Slash", 70)
                }),
            // Meowth Line
            new Pokemon("Meowth", "Normal", 40, 45, 28, "Persian",
                new List<Attack> {
                    new Attack("Scratch", 35),
                    new Attack("Pay Day", 40)
                }),
            new Pokemon("Persian", "Normal", 65, 70, 0, null,
                new List<Attack> {
                    new Attack("Slash", 70),
                    new Attack("Hyper Beam", 150)
                }),

            // Psyduck Line
            new Pokemon("Psyduck", "Water", 50, 52, 33, "Golduck",
                new List<Attack> {
                    new Attack("Water Gun", 40),
                    new Attack("Confusion", 50)
                }),
            new Pokemon("Golduck", "Water", 80, 82, 0, null,
                new List<Attack> {
                    new Attack("Hydro Pump", 110),
                    new Attack("Psychic", 90)
                }),

            // Mankey Line
            new Pokemon("Mankey", "Fighting", 40, 80, 28, "Primeape",
                new List<Attack> {
                    new Attack("Karate Chop", 50),
                    new Attack("Low Kick", 20)
                }),
            new Pokemon("Primeape", "Fighting", 65, 105, 0, null,
                new List<Attack> {
                    new Attack("Cross Chop", 100),
                    new Attack("Close Combat", 120)
                }),

            // Growlithe Line
            new Pokemon("Growlithe", "Fire", 55, 70, 36, "Arcanine",
                new List<Attack> {
                    new Attack("Bite", 60),
                    new Attack("Flame Wheel", 60)
                }),
            new Pokemon("Arcanine", "Fire", 90, 110, 0, null,
                new List<Attack> {
                    new Attack("Flare Blitz", 120),
                    new Attack("Extreme Speed", 80)
                }),

            // Poliwag Line
            new Pokemon("Poliwag", "Water", 40, 50, 25, "Poliwhirl",
                new List<Attack> {
                    new Attack("Bubble", 40),
                    new Attack("Hypnosis", 0)
                }),
            new Pokemon("Poliwhirl", "Water", 65, 65, 37, "Poliwrath",
                new List<Attack> {
                    new Attack("Waterfall", 80),
                    new Attack("Body Slam", 85)
                }),
            new Pokemon("Poliwrath", "Water/Fighting", 90, 95, 0, null,
                new List<Attack> {
                    new Attack("Dynamic Punch", 100),
                    new Attack("Surf", 90)
                }),

            // Abra Line
            new Pokemon("Abra", "Psychic", 25, 20, 16, "Kadabra",
                new List<Attack> {
                    new Attack("Teleport", 0),
                    new Attack("Psyshock", 65)
                }),
            new Pokemon("Kadabra", "Psychic", 40, 35, 37, "Alakazam",
                new List<Attack> {
                    new Attack("Psybeam", 65),
                    new Attack("Reflect", 0)
                }),
            new Pokemon("Alakazam", "Psychic", 55, 50, 0, null,
                new List<Attack> {
                    new Attack("Psychic", 90),
                    new Attack("Shadow Ball", 80)
                }),

            // Machop Line
            new Pokemon("Machop", "Fighting", 70, 80, 28, "Machoke",
                new List<Attack> {
                    new Attack("Karate Chop", 50),
                    new Attack("Low Kick", 20)
                }),
            new Pokemon("Machoke", "Fighting", 80, 100, 37, "Machamp",
                new List<Attack> {
                    new Attack("Cross Chop", 100),
                    new Attack("Seismic Toss", 50)
                }),
            new Pokemon("Machamp", "Fighting", 90, 130, 0, null,
                new List<Attack> {
                    new Attack("Dynamic Punch", 100),
                    new Attack("Close Combat", 120)
                }),
            // Bellsprout Line
            new Pokemon("Bellsprout", "Grass/Poison", 50, 75, 21, "Weepinbell",
                new List<Attack> {
                    new Attack("Vine Whip", 45),
                    new Attack("Acid", 40)
                }),
            new Pokemon("Weepinbell", "Grass/Poison", 65, 90, 36, "Victreebel",
                new List<Attack> {
                    new Attack("Razor Leaf", 55),
                    new Attack("Sludge Bomb", 90)
                }),
            new Pokemon("Victreebel", "Grass/Poison", 80, 105, 0, null,
                new List<Attack> {
                    new Attack("Solar Beam", 120),
                    new Attack("Leaf Blade", 90)
                }),

            // Tentacool Line
            new Pokemon("Tentacool", "Water/Poison", 40, 40, 30, "Tentacruel",
                new List<Attack> {
                    new Attack("Acid", 40),
                    new Attack("Bubble Beam", 65)
                }),
            new Pokemon("Tentacruel", "Water/Poison", 80, 70, 0, null,
                new List<Attack> {
                    new Attack("Hydro Pump", 110),
                    new Attack("Sludge Wave", 95)
                }),

            // Geodude Line
            new Pokemon("Geodude", "Rock/Ground", 40, 80, 25, "Graveler",
                new List<Attack> {
                    new Attack("Tackle", 35),
                    new Attack("Rock Throw", 50)
                }),
            new Pokemon("Graveler", "Rock/Ground", 55, 95, 37, "Golem",
                new List<Attack> {
                    new Attack("Rollout", 30),
                    new Attack("Earthquake", 100)
                }),
            new Pokemon("Golem", "Rock/Ground", 80, 120, 0, null,
                new List<Attack> {
                    new Attack("Stone Edge", 100),
                    new Attack("Explosion", 250)
                }),

            // Ponyta Line
            new Pokemon("Ponyta", "Fire", 50, 85, 40, "Rapidash",
                new List<Attack> {
                    new Attack("Flame Charge", 50),
                    new Attack("Stomp", 65)
                }),
            new Pokemon("Rapidash", "Fire", 65, 100, 0, null,
                new List<Attack> {
                    new Attack("Flare Blitz", 120),
                    new Attack("Fire Blast", 110)
                }),

            // Slowpoke Line
            new Pokemon("Slowpoke", "Water/Psychic", 90, 65, 37, "Slowbro",
                new List<Attack> {
                    new Attack("Water Gun", 40),
                    new Attack("Confusion", 50)
                }),
            new Pokemon("Slowbro", "Water/Psychic", 95, 75, 0, null,
                new List<Attack> {
                    new Attack("Psychic", 90),
                    new Attack("Surf", 90)
                }),

            // Magnemite Line
            new Pokemon("Magnemite", "Electric/Steel", 25, 35, 30, "Magneton",
                new List<Attack> {
                    new Attack("Thunder Shock", 40),
                    new Attack("Spark", 65)
                }),
            new Pokemon("Magneton", "Electric/Steel", 50, 60, 0, null,
                new List<Attack> {
                    new Attack("Thunderbolt", 90),
                    new Attack("Flash Cannon", 80)
                }),

            // Farfetch'd
            new Pokemon("Farfetch'd", "Normal/Flying", 52, 65, 0, null,
                new List<Attack> {
                    new Attack("Slash", 70),
                    new Attack("Air Slash", 75)
                }),

            // Doduo Line
            new Pokemon("Doduo", "Normal/Flying", 35, 85, 31, "Dodrio",
                new List<Attack> {
                    new Attack("Peck", 35),
                    new Attack("Quick Attack", 40)
                }),
            new Pokemon("Dodrio", "Normal/Flying", 60, 110, 0, null,
                new List<Attack> {
                    new Attack("Drill Peck", 80),
                    new Attack("Tri Attack", 80)
                }),
            // Seel Line
            new Pokemon("Seel", "Water", 65, 45, 34, "Dewgong",
                new List<Attack> {
                    new Attack("Headbutt", 70),
                    new Attack("Ice Shard", 40)
                }),
            new Pokemon("Dewgong", "Water/Ice", 90, 70, 0, null,
                new List<Attack> {
                    new Attack("Ice Beam", 90),
                    new Attack("Aqua Tail", 90)
                }),

            // Grimer Line
            new Pokemon("Grimer", "Poison", 80, 80, 38, "Muk",
                new List<Attack> {
                    new Attack("Sludge", 65),
                    new Attack("Mud Bomb", 65)
                }),
            new Pokemon("Muk", "Poison", 105, 105, 0, null,
                new List<Attack> {
                    new Attack("Gunk Shot", 120),
                    new Attack("Acid Armor", 0)
                }),

            // Shellder Line
            new Pokemon("Shellder", "Water", 30, 65, 36, "Cloyster",
                new List<Attack> {
                    new Attack("Icicle Spear", 25),
                    new Attack("Water Gun", 40)
                }),
            new Pokemon("Cloyster", "Water/Ice", 50, 95, 0, null,
                new List<Attack> {
                    new Attack("Hydro Pump", 110),
                    new Attack("Ice Beam", 90)
                }),

            // Gastly Line
            new Pokemon("Gastly", "Ghost/Poison", 30, 35, 25, "Haunter",
                new List<Attack> {
                    new Attack("Lick", 30),
                    new Attack("Night Shade", 50)
                }),
            new Pokemon("Haunter", "Ghost/Poison", 45, 50, 37, "Gengar",
                new List<Attack> {
                    new Attack("Shadow Ball", 80),
                    new Attack("Dream Eater", 100)
                }),
            new Pokemon("Gengar", "Ghost/Poison", 60, 65, 0, null,
                new List<Attack> {
                    new Attack("Sludge Bomb", 90),
                    new Attack("Dark Pulse", 80)
                }),

            // Onix
            new Pokemon("Onix", "Rock/Ground", 35, 45, 0, null,
                new List<Attack> {
                    new Attack("Rock Slide", 75),
                    new Attack("Earthquake", 100)
                }),

            // Drowzee Line
            new Pokemon("Drowzee", "Psychic", 60, 48, 26, "Hypno",
                new List<Attack> {
                    new Attack("Confusion", 50),
                    new Attack("Headbutt", 70)
                }),
            new Pokemon("Hypno", "Psychic", 85, 73, 0, null,
                new List<Attack> {
                    new Attack("Psychic", 90),
                    new Attack("Hypnosis", 0)
                }),

            // Krabby Line
            new Pokemon("Krabby", "Water", 30, 105, 28, "Kingler",
                new List<Attack> {
                    new Attack("Bubble Beam", 65),
                    new Attack("Vice Grip", 55)
                }),
            new Pokemon("Kingler", "Water", 55, 130, 0, null,
                new List<Attack> {
                    new Attack("Crabhammer", 100),
                    new Attack("Guillotine", 0)
                }),

            // Voltorb Line
            new Pokemon("Voltorb", "Electric", 40, 30, 30, "Electrode",
                new List<Attack> {
                    new Attack("Spark", 65),
                    new Attack("Thunder Wave", 0)
                }),
            new Pokemon("Electrode", "Electric", 60, 50, 0, null,
                new List<Attack> {
                    new Attack("Thunderbolt", 90),
                    new Attack("Explosion", 250)
                }),
            // Exeggcute Line
            new Pokemon("Exeggcute", "Grass/Psychic", 60, 40, 36, "Exeggutor",
                new List<Attack> {
                    new Attack("Confusion", 50),
                    new Attack("Bullet Seed", 25)
                }),
            new Pokemon("Exeggutor", "Grass/Psychic", 95, 95, 0, null,
                new List<Attack> {
                    new Attack("Psychic", 90),
                    new Attack("Solar Beam", 120)
                }),

            // Cubone Line
            new Pokemon("Cubone", "Ground", 50, 50, 28, "Marowak",
                new List<Attack> {
                    new Attack("Bone Club", 65),
                    new Attack("Headbutt", 70)
                }),
            new Pokemon("Marowak", "Ground", 60, 80, 0, null,
                new List<Attack> {
                    new Attack("Earthquake", 100),
                    new Attack("Bonemerang", 50)
                }),

            // Hitmonlee and Hitmonchan
            new Pokemon("Hitmonlee", "Fighting", 50, 120, 0, null,
                new List<Attack> {
                    new Attack("High Jump Kick", 130),
                    new Attack("Rolling Kick", 60)
                }),
            new Pokemon("Hitmonchan", "Fighting", 50, 105, 0, null,
                new List<Attack> {
                    new Attack("Sky Uppercut", 85),
                    new Attack("Fire Punch", 75)
                }),

            // Lickitung
            new Pokemon("Lickitung", "Normal", 90, 55, 0, null,
                new List<Attack> {
                    new Attack("Lick", 30),
                    new Attack("Stomp", 65)
                }),

            // Koffing Line
            new Pokemon("Koffing", "Poison", 40, 65, 35, "Weezing",
                new List<Attack> {
                    new Attack("Sludge", 65),
                    new Attack("Tackle", 35)
                }),
            new Pokemon("Weezing", "Poison", 65, 90, 0, null,
                new List<Attack> {
                    new Attack("Sludge Bomb", 90),
                    new Attack("Explosion", 250)
                }),

            // Rhyhorn Line
            new Pokemon("Rhyhorn", "Ground/Rock", 80, 85, 42, "Rhydon",
                new List<Attack> {
                    new Attack("Rock Blast", 25),
                    new Attack("Stomp", 65)
                }),
            new Pokemon("Rhydon", "Ground/Rock", 105, 130, 0, null,
                new List<Attack> {
                    new Attack("Earthquake", 100),
                    new Attack("Stone Edge", 100)
                }),

            // Chansey
            new Pokemon("Chansey", "Normal", 250, 5, 0, null,
                new List<Attack> {
                    new Attack("Soft-Boiled", 0),
                    new Attack("Pound", 40)
                }),

            // Tangela
            new Pokemon("Tangela", "Grass", 65, 55, 0, null,
                new List<Attack> {
                    new Attack("Vine Whip", 45),
                    new Attack("Stun Spore", 0)
                }),

            // Kangaskhan
            new Pokemon("Kangaskhan", "Normal", 105, 95, 0, null,
                new List<Attack> {
                    new Attack("Comet Punch", 18),
                    new Attack("Mega Punch", 80)
                }),
            // Horsea Line
            new Pokemon("Horsea", "Water", 30, 40, 32, "Seadra",
                new List<Attack> {
                    new Attack("Bubble", 40),
                    new Attack("Water Gun", 40)
                }),
            new Pokemon("Seadra", "Water", 55, 65, 0, null,
                new List<Attack> {
                    new Attack("Hydro Pump", 110),
                    new Attack("Twister", 40)
                }),

            // Goldeen Line
            new Pokemon("Goldeen", "Water", 45, 67, 33, "Seaking",
                new List<Attack> {
                    new Attack("Peck", 35),
                    new Attack("Waterfall", 80)
                }),
            new Pokemon("Seaking", "Water", 80, 92, 0, null,
                new List<Attack> {
                    new Attack("Horn Drill", 0),
                    new Attack("Aqua Tail", 90)
                }),

            // Staryu Line
            new Pokemon("Staryu", "Water", 30, 45, 36, "Starmie",
                new List<Attack> {
                    new Attack("Bubble Beam", 65),
                    new Attack("Rapid Spin", 50)
                }),
            new Pokemon("Starmie", "Water/Psychic", 60, 75, 0, null,
                new List<Attack> {
                    new Attack("Psychic", 90),
                    new Attack("Surf", 90)
                }),

            // Mr. Mime
            new Pokemon("Mr. Mime", "Psychic/Fairy", 40, 45, 0, null,
                new List<Attack> {
                    new Attack("Confusion", 50),
                    new Attack("Barrier", 0)
                }),

            // Scyther
            new Pokemon("Scyther", "Bug/Flying", 70, 110, 0, null,
                new List<Attack> {
                    new Attack("Slash", 70),
                    new Attack("Wing Attack", 60)
                }),

            // Jynx
            new Pokemon("Jynx", "Ice/Psychic", 65, 50, 0, null,
                new List<Attack> {
                    new Attack("Ice Beam", 90),
                    new Attack("Lovely Kiss", 0)
                }),

            // Electabuzz
            new Pokemon("Electabuzz", "Electric", 65, 83, 0, null,
                new List<Attack> {
                    new Attack("Thunderbolt", 90),
                    new Attack("Thunder Punch", 75)
                }),

            // Magmar
            new Pokemon("Magmar", "Fire", 65, 95, 0, null,
                new List<Attack> {
                    new Attack("Flamethrower", 90),
                    new Attack("Fire Punch", 75)
                }),

            // Pinsir
            new Pokemon("Pinsir", "Bug", 65, 125, 0, null,
                new List<Attack> {
                    new Attack("X-Scissor", 80),
                    new Attack("Guillotine", 0)
                }),

            // Tauros
            new Pokemon("Tauros", "Normal", 75, 100, 0, null,
                new List<Attack> {
                    new Attack("Take Down", 90),
                    new Attack("Horn Attack", 65)
                }),
            // Magikarp Line
            new Pokemon("Magikarp", "Water", 20, 10, 20, "Gyarados",
                new List<Attack> {
                    new Attack("Splash", 0),
                    new Attack("Tackle", 35)
                }),
            new Pokemon("Gyarados", "Water/Flying", 95, 125, 0, null,
                new List<Attack> {
                    new Attack("Hyper Beam", 150),
                    new Attack("Dragon Rage", 40)
                }),

            // Lapras
            new Pokemon("Lapras", "Water/Ice", 130, 85, 0, null,
                new List<Attack> {
                    new Attack("Ice Beam", 90),
                    new Attack("Surf", 90)
                }),

            // Ditto
            new Pokemon("Ditto", "Normal", 48, 48, 0, null,
                new List<Attack> {
                    new Attack("Transform", 0)
                }),

            // Eevee Line
            new Pokemon("Eevee", "Normal", 55, 55, 25, "Multiple Evolutions",
                new List<Attack> {
                    new Attack("Quick Attack", 40),
                    new Attack("Bite", 60)
                }),
            new Pokemon("Vaporeon", "Water", 130, 65, 0, null,
                new List<Attack> {
                    new Attack("Water Gun", 40),
                    new Attack("Hydro Pump", 110)
                }),
            new Pokemon("Jolteon", "Electric", 65, 110, 0, null,
                new List<Attack> {
                    new Attack("Thunderbolt", 90),
                    new Attack("Pin Missile", 25)
                }),
            new Pokemon("Flareon", "Fire", 65, 130, 0, null,
                new List<Attack> {
                    new Attack("Flamethrower", 90),
                    new Attack("Fire Spin", 35)
                }),

            // Porygon
            new Pokemon("Porygon", "Normal", 65, 60, 0, null,
                new List<Attack> {
                    new Attack("Conversion", 0),
                    new Attack("Psybeam", 65)
                }),

            // Omanyte Line
            new Pokemon("Omanyte", "Rock/Water", 35, 40, 40, "Omastar",
                new List<Attack> {
                    new Attack("Water Gun", 40),
                    new Attack("Ancient Power", 60)
                }),
            new Pokemon("Omastar", "Rock/Water", 70, 60, 0, null,
                new List<Attack> {
                    new Attack("Hydro Pump", 110),
                    new Attack("Rock Slide", 75)
                }),

            // Kabuto Line
            new Pokemon("Kabuto", "Rock/Water", 30, 80, 40, "Kabutops",
                new List<Attack> {
                    new Attack("Scratch", 40),
                    new Attack("Absorb", 20)
                }),
            new Pokemon("Kabutops", "Rock/Water", 60, 115, 0, null,
                new List<Attack> {
                    new Attack("Slash", 70),
                    new Attack("Hydro Pump", 110)
                }),

            // Aerodactyl
            new Pokemon("Aerodactyl", "Rock/Flying", 80, 105, 0, null,
                new List<Attack> {
                    new Attack("Wing Attack", 60),
                    new Attack("Rock Slide", 75)
                }),
            // Snorlax
        new Pokemon("Snorlax", "Normal", 160, 110, 0, null,
            new List<Attack> {
                new Attack("Body Slam", 85),
                new Attack("Hyper Beam", 150)
            }),

        // Legendary Birds
        new Pokemon("Articuno", "Ice/Flying", 90, 85, 0, null,
            new List<Attack> {
                new Attack("Ice Beam", 90),
                new Attack("Blizzard", 110)
            }),
        new Pokemon("Zapdos", "Electric/Flying", 90, 90, 0, null,
            new List<Attack> {
                new Attack("Thunderbolt", 90),
                new Attack("Drill Peck", 80)
            }),
        new Pokemon("Moltres", "Fire/Flying", 90, 100, 0, null,
            new List<Attack> {
                new Attack("Flamethrower", 90),
                new Attack("Fire Blast", 110)
            }),

        // Dratini Line
        new Pokemon("Dratini", "Dragon", 41, 64, 30, "Dragonair",
            new List<Attack> {
                new Attack("Wrap", 15),
                new Attack("Twister", 40)
            }),
        new Pokemon("Dragonair", "Dragon", 61, 84, 55, "Dragonite",
            new List<Attack> {
                new Attack("Dragon Rage", 40),
                new Attack("Slam", 80)
            }),
        new Pokemon("Dragonite", "Dragon/Flying", 91, 134, 0, null,
            new List<Attack> {
                new Attack("Hyper Beam", 150),
                new Attack("Outrage", 120)
            }),

        // Mewtwo
        new Pokemon("Mewtwo", "Psychic", 106, 154, 0, null,
            new List<Attack> {
                new Attack("Psychic", 90),
                new Attack("Shadow Ball", 80)
            }),

        // Mew
        new Pokemon("Mew", "Psychic", 100, 100, 0, null,
            new List<Attack> {
                new Attack("Psychic", 90),
                new Attack("Aura Sphere", 80)
            }),
        };
    }
}
