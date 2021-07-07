using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    class MultipleChoice : QuestionNS
    {
        public MultipleChoice(string question)
            : base(question)
        {

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
