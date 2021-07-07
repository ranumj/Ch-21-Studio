using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    public abstract class QuestionNS
    {
        public int QuestionNumber { get; set; }
        public string Question { get; set; }
        public string UserAnswer { get; set; }
        public bool AnswerIsCorrect { get; set; }
        
        public QuestionNS(string question)
        {
            Question = question;
        }

        public virtual string PromptUserInput()
        {
            Console.WriteLine(Question);
            UserAnswer = Console.ReadLine();
            this.VerifyUserAnswer();
            return UserAnswer;
        }

        public virtual bool VerifyUserAnswer()
        {
            if (AnswerIsCorrect)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
            return AnswerIsCorrect;
        }
    }
}
