using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PokemonInspire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the Pokémon Game System!");
                Console.WriteLine("1. Sign Up");
                Console.WriteLine("2. Log In");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AuthService.SignUp();
                        break;
                    case "2":
                        AuthService.LogIn();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();

                Console.WriteLine("Welcome to the Pokémon Game System!");
                Console.WriteLine("Please choose one of the following Pokémon to begin your journey:");

                // Create 3 Pokémon options
                Pokemon[] pokemons = new Pokemon[]
                {
                new Pokemon("Bulbasaur", 1, 100, 20),
                new Pokemon("Charmander", 1, 100, 25),
                new Pokemon("Squirtle", 1, 100, 15)
                };

                // Display the Pokémon options
                for (int i = 0; i < pokemons.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {pokemons[i].Name} (Level {pokemons[i].Level}, HP {pokemons[i].HP}, Attack {pokemons[i].Attack})");
                }

                // Get the user's choice
                int userChoice = 0;
                while (userChoice < 1 || userChoice > 3)
                {
                    Console.Write("Choose your Pokémon (1-3): ");
                    bool validChoice = int.TryParse(Console.ReadLine(), out userChoice);
                    if (!validChoice || userChoice < 1 || userChoice > 3)
                    {
                        Console.WriteLine("Invalid choice. Please choose a number between 1 and 3.");
                    }
                }

                // Store the chosen Pokémon
                Pokemon chosenPokemon = pokemons[userChoice - 1];
                Console.WriteLine($"You have chosen {chosenPokemon.Name}!");

                // Now, proceed to the next part (e.g., game menu)
                ShowGameMenu();
            }

        }

        private static void ShowGameMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Instructions");
            Console.WriteLine("3. Back");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    // Start the game
                    Console.WriteLine("Starting the game...");
                    break;
                case "2":
                    // Show instructions
                    Console.WriteLine("Showing instructions...");
                    break;
                case "3":
                    // Go back
                    Console.WriteLine("Going back...");
                    break;
                case "4":
                    // Exit
                    Console.WriteLine("Exiting the game. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid number.");
                    ShowGameMenu();
                    break;
            }
        }
    }
}
