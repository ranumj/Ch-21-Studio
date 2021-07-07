using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    class MultipleChoice : QuestionNS
    {
        public char CorrectAnswer { get; set; }
        public string[] PossibleAnswers { get; set; }

        public MultipleChoice(string question, char answer)
            : base(question)
        {
            CorrectAnswer = answer;
        }

        public MultipleChoice(string question, string[] possibleAnswers, char answer)
            : base(question)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswer = answer;
        }

        public override string PromptUserInput()
        {
            //Console.WriteLine(PossibleAnswers);
            for (int i = 0; i < PossibleAnswers.Length; i++)
            {
                Console.WriteLine(PossibleAnswers[i]);
            }
            return base.PromptUserInput();
        }

        public override bool VerifyUserAnswer()
        {
            if (UserAnswer.Length == 1)
            {
                if (UserAnswer.Contains(CorrectAnswer))
                {
                    AnswerIsCorrect = true;
                }
                else
                {
                    AnswerIsCorrect = false;
                }
            }
            else
            {
                Console.WriteLine("Please enter a, b, c, or d.");
                VerifyUserAnswer();
            }
            return base.VerifyUserAnswer();
        }

        // What is Rae's favorite flavor of ice cream?
        // a. Chocolate - correct answer
        // b. Vanilla
        // c. Strawberry
        // d. Corn and cheese
        // If user picks a), return AnswerCorrect = true;
        // If user picks any other answer, return AnswerCorrect = false;
    }
}
