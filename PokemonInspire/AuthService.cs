using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInspire
{
    public static class AuthService
    {
        // List to store all registered users
        private static List<User> users = new List<User>();

        public static void SignUp()
        {
            Console.WriteLine("\n--- Sign Up ---");
            string username;
            while (true)
            {
                Console.Write("Enter a username: ");
                username = Console.ReadLine()?.Trim();
                // Check if username already exists
                foreach (var user in users)
                {
                    if (user.Username == username)
                    {
                        Console.WriteLine("Username already exists. Please try a different one.");
                        return;
                    }
                }

                if (string.IsNullOrEmpty(username))
                {
                    Console.WriteLine("Username cannot be empty or spaces. Please try again.");
                }
                else
                {
                    break;
                }

            }
            string password;
            string confirmPassword;

            Console.Write("Enter a password: ");

            while (true)
            {
                Console.Write("Enter a password (minimum 6 characters): ");
                password = Console.ReadLine();

                if (password.Length < 6)
                {
                    Console.WriteLine("Password must be at least 10 characters long. Please try again.");
                    continue;
                }

                Console.Write("Retype your password: ");
                confirmPassword = Console.ReadLine();

                if (password != confirmPassword)
                {
                    Console.WriteLine("Passwords do not match. Please try again.");
                }
                else
                {
                    break;
                }
            }

            User newUser = new User(username, password);
            User.SaveUser(newUser);

            Console.WriteLine("Sign-up successful!");
            Console.WriteLine("Press any key to go back to the main menu...");
            Console.ReadKey();
        }
        public static void LogIn()
        {
            Console.WriteLine("\n--- Log In ---");

            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (User.ValidateLogin(username, password))
            {
                Console.WriteLine("Login successful!");
                // Load user data
                User loggedInUser = User.LoadUser(username);
                Console.WriteLine($"Welcome back, {loggedInUser.Username}!");
                Console.WriteLine($"Your current level: {loggedInUser.Level}, XP: {loggedInUser.XP}");
                Console.WriteLine("Press any key to start playing...");
                Console.ReadKey();
                // Here, you can start the game flow or proceed to the game menu.
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                Console.WriteLine("Press any key to go back...");
                Console.ReadKey();
            }
        }
    }
}