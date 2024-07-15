using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Quilaton
{
    public class Question
    {
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string text, string[] choices, string correctAnswer)
        {
            Text = text;
            Choices = choices;
            CorrectAnswer = correctAnswer;
        }

        public static Question[] GetEnglishQuestions()
        {
            return new Question[]
            {
                //ENGLISH
                new Question("Identify the subject in the following sentence: “The cat sat on the mat.”",
                             new string[] { "a) The cat", "b) sat", "c) on", "d) the mat" }, "a"),
                new Question("Choose the correct form: “She (goes, go) to school every day.”",
                             new string[] { "a) goes", "b) go" }, "a"),
                new Question("Is the following sentence in the past, present, or future tense? “He will eat dinner at 7 PM.”",
                             new string[] { "a) Past", "b) Present", "c) Future" }, "c"),
                new Question("Correct the sentence: “I has a new book.”",
                             new string[] { "a) I have a new book.", "b) I had a new book.", "c) I having a new book.", "d) I has a new books." }, "a"),
                new Question("What is the plural form of the word “child”?",
                             new string[] { "a) childs", "b) children", "c) childs’", "d) childrens" }, "b")
            };
        }

        public static Question[] GetMathQuestions()
        {
            return new Question[]
            {
                //MATH
                new Question("What is 7 + 5?",
                             new string[] { "a) 10", "b) 11", "c) 12", "d) 13" }, "c"),
                new Question("What is the value of 9 - 4?",
                             new string[] { "a) 3", "b) 4", "c) 5", "d) 6" }, "c"),
                new Question("What is 3 × 6?",
                             new string[] { "a) 12", "b) 15", "c) 18", "d) 21" }, "c"),
                new Question("What is the value of 16 ÷ 4?",
                             new string[] { "a) 2", "b) 3", "c) 4", "d) 5" }, "c"),
                new Question("What is the square root of 25?",
                             new string[] { "a) 3", "b) 4", "c) 5", "d) 6" }, "c")
            };
        }

        public static Question[] GetScienceQuestions()
        {
            return new Question[]
            {
                //SCIENCE
                new Question("What planet is known as the Red Planet?",
                             new string[] { "a) Earth", "b) Mars", "c) Jupiter", "d) Venus" }, "b"),
                new Question("What gas do plants absorb from the atmosphere during photosynthesis?",
                             new string[] { "a) Oxygen", "b) Nitrogen", "c) Carbon Dioxide", "d) Hydrogen" }, "c"),
                new Question("What is the boiling point of water at sea level?",
                             new string[] { "a) 50°C", "b) 75°C", "c) 100°C", "d) 125°C" }, "c"),
                new Question("Which organ pumps blood throughout the human body?",
                             new string[] { "a) Lungs", "b) Liver", "c) Brain", "d) Heart" }, "d"),
                new Question("What is the chemical symbol for water?",
                             new string[] { "a) H", "b) O", "c) CO₂", "d) H₂O" }, "d")
            };
        }
    }
}
