using System;
using System.Linq; // need Linq for the Where method

namespace anna_hw2_PickAUniqueCardBlazor
{
    public class CardPicker
    {
        //declare
        static Random random = new Random();
        static string[] cards = new string[52]; //card candidaters array
        static int leftCardsNum = 52; //number of left cards

        static CardPicker()
        {
            initializeCards(); //initialize

            // This just tests that we are getting all of our cards
            /*for (var i = 0; i < 52; i++)
            {
                //Console.WriteLine(cards[i]);
            }*/
        }

        /*** FUNCTION: initializeCards ***
        input: none
        output: noen
        > initialize the cards
        ***/
        public static void initializeCards()
        {
            //declare
            string[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" }; //kinds of suits
            int cardCounter = 0; //counter

            //reset
            cards = new string[52]; //reset cards
            leftCardsNum = 52; //reset leftCardsNumber

            //generate all the cards
            for (int cardVal = 1; cardVal <= 13; cardVal++)
            {
                foreach (string cardSuit in suits)
                {
                    string cardName;
                    switch (cardVal)
                    {
                        case 1:
                            cardName = "Ace";
                            break;
                        case 11:
                            cardName = "Jack";
                            break;
                        case 12:
                            cardName = "Queen";
                            break;
                        case 13:
                            cardName = "King";
                            break;
                        default:
                            cardName = cardVal.ToString();
                            break;
                    }

                    cards[cardCounter] = cardName + " of " + cardSuit; //pass the card with current suit and number to cards array
                    cardCounter++; //counter + 1 and pass back to itself
                }
            }

        }

        /*** FUNCTION: PickSomeCards ***
        input: int numberOfCards
        output: string[] pickedCards
        > pick some random cards
        ***/
        public static string[] PickSomeCards(int numberOfCards)
        {
            //declare
            string[] pickedCards = new string[numberOfCards]; //picked cards array

            //pick cards based on the number that the player set
            for (int i = 0; i < numberOfCards; i++)
            {
                // pickedCards[i] = RandomValue() + " of " + RandomSuit();
                pickedCards[i] = RandomCard(); //random card and pass to pickedCard
            }
            
            return pickedCards; //return the array of pickedCards
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }

        /*** FUNCTION: RandomCard ***
        input: none
        output: string picked
        > random and pick a card, remove it from the card candidater array, return picked one
        ***/
        private static string RandomCard()
        {
            int cardNum = random.Next(0, cards.Length); //random number (min:0, max:the legth of cards array) and pass to cardNum
            string picked = cards[cardNum]; //pass the card to picked according to the index

            //C# where method
            //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-7.0
            cards = cards.Where(e => e != picked).ToArray(); //filter, remove the one is picked
            leftCardsNum = cards.Length; //pass length of cards to leftCardsnum

            return picked; //return picked
        }

        /*** FUNCTION: GetLeftCardsNum ***
        input: none
        output: int leftCardsNum
        > return the current leftCardsNum
        ***/
        public static int GetLeftCardsNum()
        {
            return leftCardsNum; //return leftCardsNum
        }
    }
}

//error message:
//line 86 : string picked = cards[cardNum];
//Index was outside the bounds of the array.

