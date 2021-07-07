using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Studio
{
    class Checkbox : Question
    {
        public Checkbox(string question)
            : base(question)
        {
            QuestionBody = question;
        }
    }
}
