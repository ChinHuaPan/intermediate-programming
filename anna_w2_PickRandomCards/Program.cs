using System;

namespace anna_w2_PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cards = CardPicker.PickSomeCards(5);

            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

        }
    }
}
