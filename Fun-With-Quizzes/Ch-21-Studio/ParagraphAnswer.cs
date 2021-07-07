using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    class ParagraphAnswer : Question
    {
        public ParagraphAnswer(string question)
            : base(question)
        {
            QuestionBody = question;
        }
    }
}
