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

            // Check if username already exists
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    Console.WriteLine("Username already exists. Please try a different one.");
                    return;
                }
            }

            while (true)
            {
                Console.Write("Enter a password (minimum 10 characters): ");
                password = Console.ReadLine();

                if (password.Length < 10)
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

            // Create and add a new user
            users.Add(new User(username, password));
            Console.WriteLine("Sign Up successful! You can now log in.");
        }
        public static void LogIn()
        {
            Console.WriteLine("\n--- Log In ---");

            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Validate username and password
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    Console.WriteLine($"Welcome back, {username}!");
                    return;
                }
            }

            Console.WriteLine("Invalid username or password. Please try again.");
        }
    }
}
