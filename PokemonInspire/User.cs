using System;
using System.Collections.Generic;
using System.IO;

namespace PokemonInspire
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ChosenPokemon { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }

        // Constructor to initialize a new user
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            ChosenPokemon = "";
            Level = 1;
            XP = 0;
        }

        // Save user data to a file (e.g., username and password)
        public static void SaveUser(User user)
        {
            string path = $"{user.Username}.txt"; // Save file by username
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(user.Username);
                writer.WriteLine(user.Password);
                writer.WriteLine(user.ChosenPokemon);
                writer.WriteLine(user.Level);
                writer.WriteLine(user.XP);
            }
        }

        // Load user data from a file
        public static User LoadUser(string username)
        {
            string path = $"{username}.txt";
            if (File.Exists(path))
            {
                string[] data = File.ReadAllLines(path);
                User loadedUser = new User(data[0], data[1]);
                loadedUser.ChosenPokemon = data[2];
                loadedUser.Level = int.Parse(data[3]);
                loadedUser.XP = int.Parse(data[4]);
                return loadedUser;
            }
            return null;
        }

        // Validate login
        public static bool ValidateLogin(string username, string password)
        {
            string path = $"{username}.txt";
            if (File.Exists(path))
            {
                string[] data = File.ReadAllLines(path);
                return data[1] == password; // Check if password matches
            }
            return false;
        }
    }
}