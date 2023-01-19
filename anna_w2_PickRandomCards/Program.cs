using System;

namespace anna_w2_PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cards = CardPicker.PickSomeCards(5);

            Console.Write("Enter the number of cards to pick: "); //show the sentence to ask the user to enter a number

            string line = Console.ReadLine(); //read the line that the user enters

            //if the user enters a valid number
            //parse "line" to int and pass to "numberOfCards"
            if (int.TryParse(line, out int numberOfCards)) 
            {
                //repeat for amount of "CardPicker.PickSomeCards(numberOfCards)" returns
                //when "CardPicker.PickSomeCards(numberOfCards)" return something, pass it to card and do the following things
                //until there is no return of "CardPicker.PickSomeCards(numberOfCards)"
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card); //show "card" in the console
                }
            }
            //if the user enters an invalid number 
            else
            {
                Console.WriteLine("Please enter a valid number."); //show the reminder
            }

        }
    }
}
