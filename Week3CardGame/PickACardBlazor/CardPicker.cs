using System;
using System.Linq; // need Linq for the Where method

namespace PickACardBlazor // need to change this to match project
{
    public class CardPicker
    {
        static Random random = new Random();
        static string[] cards = new string[52];

        static CardPicker()
        {

            BuildDeck();
        }

        public static void BuildDeck()
        {
            cards = new string[52];

            string[] suits = { "spades", "hearts", "clubs", "diamonds" };
            int cardCounter = 0;

            for (int cardVal = 1; cardVal <= 13; cardVal++)
            {
                foreach (string cardSuit in suits)
                {
                    string cardName;
                    switch (cardVal)
                    {
                        case 1:
                            cardName = "A";
                            break;
                        case 11:
                            cardName = "J";
                            break;
                        case 12:
                            cardName = "Q";
                            break;
                        case 13:
                            cardName = "K";
                            break;
                        default:
                            cardName = cardVal.ToString().PadLeft(2, '0');
                            break;
                    }

                    cards[cardCounter] = "card_" + cardSuit + "_" + cardName + ".png";
                    cardCounter++;
                }
            }
        }

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];

            if(numberOfCards <= cards.Length)
            {
                for (int i = 0; i < numberOfCards; i++)
                {
                    // pickedCards[i] = RandomValue() + " of " + RandomSuit();
                    pickedCards[i] = RandomCard();
                }   
                return pickedCards;
            }
            else
            {
                return null;
            }
                   
        }

        private static string RandomCard()
        {
            int cardNum = random.Next(0, cards.Length);
            string picked = cards[cardNum];
            cards = cards.Where(e => e != picked).ToArray();
            return picked;
        }
    }
}
