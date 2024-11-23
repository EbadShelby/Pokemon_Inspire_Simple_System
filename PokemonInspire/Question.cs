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

        public Question(string questionText, List<string> options, string correctAnswer)
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
}
