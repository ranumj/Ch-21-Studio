using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    public class Quiz
    {
        public List<Question> Questions = new List<Question>();
        public int CorrectAnswers = 0;

        public Quiz()
        {
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public double CalculateScore()
        {
            foreach (Question question in Questions)
            {
                if (question.VerifyUserAnswer())
                {
                    CorrectAnswers++;
                }
            }
            double score = CorrectAnswers*100 / Questions.ToArray().Length;
            Console.WriteLine($"You had {CorrectAnswers} correct answers out of {Questions.ToArray().Length}. Your score is {score}%.");
            return score;
        }
    }
}
