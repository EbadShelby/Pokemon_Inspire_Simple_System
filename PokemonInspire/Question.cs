using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInspire
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public string CorrectAnswer { get; set; }
        public string Difficulty { get; set; } // Easy, Medium, Hard

        public Question(string questionText, List<string> options, string correctAnswer, string difficulty)
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswer = correctAnswer;
            Difficulty = difficulty;
        }
    }
}
