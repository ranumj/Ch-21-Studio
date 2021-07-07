using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    public abstract class Question
    {
        public int QuestionNumber { get; set; }
        public string QuestionBody { get; set; }
        public string UserAnswer { get; set; }
        public bool AnswerIsCorrect { get; set; }


        public Question(string question)
        {
            QuestionBody = question;
        }

        public virtual string PromptUserInput()
        {
            UserAnswer = Console.ReadLine();
            VerifyUserAnswer();
            if (VerifyUserAnswer())
            {
                Console.WriteLine("Correct!\n");
            }
            else
            {
                Console.WriteLine("Incorrect.\n");
            }
            return UserAnswer;
        }

        public virtual bool VerifyUserAnswer()
        {
            if (AnswerIsCorrect)
            {
                AnswerIsCorrect = true;
            }
            else
            {
                AnswerIsCorrect = false;
            }
            return AnswerIsCorrect;
        }
    }
}
