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
            Console.OutputEncoding = Encoding.UTF8;
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
            }
        }
    }
}
