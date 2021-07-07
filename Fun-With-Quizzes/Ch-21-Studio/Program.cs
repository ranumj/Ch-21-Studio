using System;

namespace Ch_21_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            TrueOrFalse isRaePretty = new TrueOrFalse("Is Rae pretty?", true);
            isRaePretty.PromptUserInput();

            TrueOrFalse perpetualLackOfFulfillment = new TrueOrFalse("If I pass this internship and acquire a job at Microsoft, I will find all of the happiness and self-fulfillment that I seek.", false);
            perpetualLackOfFulfillment.PromptUserInput();

        }
    }
}
