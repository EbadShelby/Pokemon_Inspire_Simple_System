using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInspire
{
    public static class QuestionBank
    {
        public static List<Question> Questions = new List<Question>
    {
        new Question(
            "What does 'int' stand for in programming?",
            new List<string> { "Integer", "Internet", "Interval", "Internal" },
            "Integer",
            "Easy"
        ),
        new Question(
            "Which of the following is a loop structure in C#?",
            new List<string> { "if-else", "for", "switch", "case" },
            "for",
            "Easy"
        ),
        new Question(
            "What is the correct syntax for declaring a variable in C#?",
            new List<string> { "int varName;", "declare int varName;", "int: varName;", "varName int;" },
            "int varName;",
            "Medium"
        ),
        new Question(
            "What is polymorphism in OOP?",
            new List<string> {
                "Ability to take multiple forms",
                "Inheritance of multiple classes",
                "Encapsulation of data",
                "None of the above"
            },
            "Ability to take multiple forms",
            "Hard"
        )
    };
    }
}
