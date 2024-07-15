
using System;

namespace Final_Quilaton
{  class Program
    { static void Main(string[] args)
        {
            // questions kada sub
            Question[] englishQuestions = Question.GetEnglishQuestions();
            Question[] mathQuestions = Question.GetMathQuestions();
            Question[] scienceQuestions = Question.GetScienceQuestions();

            Ranking ranking = new Ranking(100);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. English");
                Console.WriteLine("2. Math");
                Console.WriteLine("3. Science");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    ShowSubjectMenu("English", englishQuestions, ranking, 0);
                }
                else if (choice == "2")
                {
                    ShowSubjectMenu("Math", mathQuestions, ranking, 1);
                }
                else if (choice == "3")
                {
                    ShowSubjectMenu("Science", scienceQuestions, ranking, 2);
                }
                else if (choice == "4")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid selection. Try again.");
                    Console.ReadKey();
                }
            }
        }

        static void ShowSubjectMenu(string subject, Question[] questions, Ranking ranking, int subjectIndex)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Take a Test");
                Console.WriteLine("2. Ranking");
                Console.WriteLine("3. Back");
                Console.Write("Select an option (1-3): ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    TakeTest(subject, questions, ranking, subjectIndex);
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    ranking.ShowRanking(subject, subjectIndex);
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid selection. Try again.");
                    Console.ReadKey();
                }
            }
        }

        static void TakeTest(string subject, Question[] questions, Ranking ranking, int subjectIndex)
        {
            Console.Clear();
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hello, " + userName + "! the quiz will start in a second, kindly please wait :) ...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Loading... :3");
            Console.ReadKey();





            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.Clear();
                Console.WriteLine(questions[i].Text);
                foreach (var choice in questions[i].Choices)
                {
                    Console.WriteLine(choice);
                }

                Console.Write("Enter your answer: ");
                string userAnswer = Console.ReadLine();

                if (userAnswer.Equals(questions[i].CorrectAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
                Console.Clear();
                Console.WriteLine($"The correct answer is {questions[i].CorrectAnswer} ");
                Console.ReadKey();
            }

            ranking.AddScore(userName, score, subjectIndex);

            Console.Clear();
            Console.WriteLine($"YIPEEEE this is your score: {score}");
            Console.WriteLine("\nYou can check the overall ranking in the menu! :3");
            Console.ReadKey();
        }
    }
}









