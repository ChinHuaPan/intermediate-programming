using System;
using System.Collections.Generic;
using System.Linq; // currently only needed if we use alternate shuffle method

namespace RaceTo21Blazor
{
    public class Deck
    {
        List<Card> cards = new List<Card>(); // creat list of card
        static public Dictionary<string, string> cardsFileName = new Dictionary<string, string>(); // create a dictionary for cardsFileName

        public Deck()
        {
            Console.WriteLine("*********** Building deck...");

            /*************************************************
             * Use these two foreach loops to build all cards
             * ***********************************************/
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

                    cards.Add(card); // build the card
                    // store the file name of card to the cardsFileName dictionary
                    cardsFileName.Add(card.Id, "card_assets/card_" + cardSuit.ToString().ToLower() + "_" + cardFileVal + ".png"); 
                }
            }
        }

        /* ********* Shuffle() **********
         * Shuffle cards
         * Called by Game object
         * INPUT: none
         * OUTPUT: none
         */
        public void Shuffle()
        {
            Console.WriteLine("Shuffling Cards...");

            Random rng = new Random(); // create a random

            // use this loop to switch the positions of cards
            for (int i = 0; i < cards.Count; i++)
            {
                Card tmp = cards[i];
                int swapindex = rng.Next(cards.Count);
                cards[i] = cards[swapindex];
                cards[swapindex] = tmp;
            }
        }

        /* ********* Shuffle() **********
         * Take the card from top and remove it from the cards
         * Called by Game object
         * INPUT: none
         * OUTPUT: Card card --> return the top card
         */
        public Card DealTopCard()
        {
            Card card = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);

            return card;
        }

        /* ********* initializeGame() **********
         * Initialize the game
         * Called by Game object
         * INPUT: List<Player> players --> the player list
         * OUTPUT: none
         * */
        //public void initializeGame(List<Player> players)
        //{
        //    CardTable cardTable = new CardTable(); // create a new cardTable
        //    Game game = new Game(cardTable, players); // create a new game

        //    while (Game.nextTask != Tasks.GameOver) // when game is not over
        //    {
        //        game.DoNextTask(); // do the next task
        //    }
        //}

        /* ********* shufflePlayers() **********
         * Shuffle the players
         * Called by Game object
         * INPUT: List<Player> players ---> the current players
         * OUTPUT: List<Player> players ---> the shuffled players
         * **/
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

