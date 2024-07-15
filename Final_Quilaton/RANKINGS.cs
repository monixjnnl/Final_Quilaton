using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Quilaton
{
    public class Ranking
    {
        public string[] Names { get; set; }
        public int[,] Scores { get; set; }
        public int UserCount { get; set; }

        public Ranking(int size)
        {
            Names = new string[size];
            Scores = new int[size, 3];
            UserCount = 0;
        }

        public void AddScore(string name, int score, int subjectIndex)
        {
            bool userExists = false;
            for (int i = 0; i < UserCount; i++)
            {
                if (Names[i] == name)
                {
                    Scores[i, subjectIndex] = score;
                    userExists = true;
                    break;
                }
            }

            if (!userExists)
            {
                Names[UserCount] = name;
                Scores[UserCount, subjectIndex] = score;
                UserCount++;
            }
        }

        public void ShowRanking(string subject, int subjectIndex)
        {
            string caption = subject switch
            {
                "English" => "CONGRATS! This is the overall ranking :)",
                "Math" => "CONGRATS! This is the overall ranking :)",
                "Science" => "CONGRATS! This is the overall ranking :)",
                _ => ""
            };

            Console.WriteLine($"{caption}");
          

            for (int i = 0; i < UserCount; i++)
            {
                Console.WriteLine($"{i + 1}. {Names[i]} - {Scores[i, subjectIndex]}");
            }
        }
    }
}
