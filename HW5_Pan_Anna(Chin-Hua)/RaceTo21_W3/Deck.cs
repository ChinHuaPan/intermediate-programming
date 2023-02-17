using System;
using System.Collections.Generic;
using System.Linq; // currently only needed if we use alternate shuffle method

namespace RaceTo21
{
    public class Deck
    {
        List<Card> cards = new List<Card>(); // creat list of card
        Dictionary<string, string> cardsFileName = new Dictionary<string, string>(); // create a dictionary for cardsFileName

        public Deck()
        {
            Console.WriteLine("*********** Building deck...");
            string[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" };

            // create cards with 13 numbers and 4 suits
            for (int cardVal = 1; cardVal <= 13; cardVal++)
            {
                foreach (string cardSuit in suits)
                {
                    string cardName;
                    string cardLongName;
                    switch (cardVal)
                    {
                        case 1:
                            cardName = "A";
                            cardLongName = "Ace";
                            break;
                        case 11:
                            cardName = "J";
                            cardLongName = "Jack";
                            break;
                        case 12:
                            cardName = "Q";
                            cardLongName = "Queen";
                            break;
                        case 13:
                            cardName = "K";
                            cardLongName = "King";
                            break;
                        default:
                            cardName = cardVal.ToString();
                            cardLongName = cardVal.ToString();
                            break;
                    }
                    // add the created card to the list
                    cards.Add(new Card(cardName + cardSuit.First<char>(), cardLongName + " of " +cardSuit));
                    // store the file name of card to the cardsFileName dictionary
                    cardsFileName.Add(cardName + cardSuit.First<char>(), "card_" + cardSuit.ToLower() + "_" + cardName + ".png");
                }
            }
        }

        /* Shuffle cards
         * Called by Game object
         */
        public void Shuffle()
        {
            Console.WriteLine("Shuffling Cards...");

            Random rng = new Random(); // create a random

            // one-line method that uses Linq:
            // cards = cards.OrderBy(a => rng.Next()).ToList();

            // multi-line method that uses Array notation on a list!
            // (this should be easier to understand)
            for (int i=0; i<cards.Count; i++)
            {
                Card tmp = cards[i];
                int swapindex = rng.Next(cards.Count);
                cards[i] = cards[swapindex];
                cards[swapindex] = tmp;
            }

            //private static readonly Random random = new Random();

            //Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
            //Console.WriteLine(card.Name);
        }

        /* Maybe we can make a variation on this that's more useful,
         * but at the moment it's just really to confirm that our 
         * shuffling method(s) worked! And normally we want our card 
         * table to do all of the displaying, don't we?!
         */

        // Show all cards for reference
        // Called by Game object
        public void ShowAllCards()
        {
            for (int i=0; i<cards.Count; i++) // show every card
            {
                Console.Write(i+":"+cards[i].displayName); // a list property can look like an Array!

                if (i < cards.Count -1)
                {
                    Console.Write(" ");
                } else
                {
                    Console.WriteLine("");
                }
            }
        }

        // Deal the top card
        // Called by Game object
        public Card DealTopCard()
        {
            Card card = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            // Console.WriteLine("I'm giving you " + card);
            return card;
        }

        // Initialize the game
        // Called by Game object
        public void initializeGame(List<Player> players)
        {
            CardTable cardTable = new CardTable(); // create a new cardTable
            Game game = new Game(cardTable, players); // create a new game

            while (game.nextTask != Task.GameOver) // when game is not over
            {
                game.DoNextTask(); // do the next task
            }
        }

        // Shuffle the players
        // Called by Game object
        public List<Player> shufflePlayers(List<Player> players)
        {
            Random rng = new Random(); // create a rendom

            for (int i = 0; i < players.Count; i++) // check every player
            {
                Player tmp = players[i]; // pass the current play to temp player
                int swapindex = rng.Next(players.Count); // store swapindex
                players[i] = players[swapindex]; // pass it to the current player
                players[swapindex] = tmp; // pass temp player to the other one
            }

            return players;
        }
    }
}

