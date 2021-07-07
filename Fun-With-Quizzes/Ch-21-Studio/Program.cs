using System;

namespace Ch_21_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            TrueOrFalse isRaePretty = new TrueOrFalse("True or False: Is Rae pretty?", true);
            isRaePretty.PromptUserInput();

            TrueOrFalse perpetualLackOfFulfillment = new TrueOrFalse("True or False: If I pass this internship and acquire a job at Microsoft, I will find all of the happiness and self-fulfillment that I seek.", false);
            perpetualLackOfFulfillment.PromptUserInput();

            MultipleChoice iceCream = new MultipleChoice("What is Rae's favorite flavor of ice cream?", new string[] { "a. Chocolate", "b. Vanilla", "c. Strawberry" }, 'a');
            iceCream.PromptUserInput();
        }
    }
}
