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

            foreach (Values cardVal in Enum.GetValues(typeof(Values)))
            {

                foreach (Suits cardSuit in Enum.GetValues(typeof(Suits)))
                {

                    string cardFileVal;

                    switch ((int)cardVal)
                    {
                        case 1:
                            cardFileVal = "A";
                            break;
                        case 11:
                            cardFileVal = "J";
                            break;
                        case 12:
                            cardFileVal = "Q";
                            break;
                        case 13:
                            cardFileVal = "K";
                            break;
                        default:
                            cardFileVal = ((int)cardVal).ToString().PadLeft(2, '0');
                            break;
                    }

                    Card card = new Card(cardVal, cardSuit);

                    cards.Add(card);

                    // store the file name of card to the cardsFileName dictionary
                    cardsFileName.Add(card.Id, "card_" + cardSuit.ToString().ToLower() + "_" + cardFileVal + ".png"); ;
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
                Console.Write(i + ":" + cards[i].Name); // a list property can look like an Array!

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

