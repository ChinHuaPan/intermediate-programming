using System;
namespace anna_w2_PickRandomCards
{
    public class CardPicker
    {
        static Random random = new Random(); //create a random

        //PickSomeCards
        //input: int  numberOfCards
        //output: array pickedCards
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards]; //create an array with string type to store picked cards with the amount of cards

            for (int i = 0; i < numberOfCards; i++) //loop to repeat for "numberOfCards" times
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit(); // pass "value of suit" to the specific pickedCards[i]
            }

            return pickedCards; //return pickedCards array
        }

        //RandomValue
        //input: none
        //output: string value
        private static string RandomValue()
        {
            //random.Next(min, max)
            //min: the INCLUSIVE lower bound of the random number returned
            //max: the EXCLUSIVE upper bound of the random number returned
            //reference: https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-7.0#system-random-next(system-int32-system-int32)
            int value = random.Next(1, 14); //give a random number between 1(inclusive) and 14(exclusive) to value

            if (value == 1) return "Ace"; //if value is 1, return "Ace"
            if (value == 11) return "Jack"; //if value is 11, return "Jack"
            if (value == 12) return "Queen"; //if value is 12, return "Queen"
            if (value == 13) return "King"; //if value is 13, return "King"

            return value.ToString(); //if the random value is not above numbers, transform to string and return directly
        }

        //RandomSuit
        //input: none
        //output: string suit
        private static string RandomSuit()
        {
            int suit = random.Next(1, 5); //give a random number between 1(inclusive) and 5(exclusive) to suit

            if (suit == 1) return "Spades"; //if suit is 1, return "Spades"
            if (suit == 2) return "Hearts"; //if suit is 2, return "Hearts"
            if (suit == 3) return "Clubs"; //if suit is 3, return "Clubs"

            return "Diamonds"; //if the random suit is not above number, return "Diamonds"

        }
    }
}
