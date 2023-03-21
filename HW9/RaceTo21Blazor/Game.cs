using System;
using System.Collections.Generic;


namespace RaceTo21Blazor
{
    public class Game
    {
        static public int maxPlayers = 8;
        static public List<Player> players = new List<Player>(2); // list of objects containing player data
        static public CardTable cardTable; // object in charge of displaying game information
        static public Deck deck = new Deck(); // deck of cards
        static public int currentPlayer = 0; // current player on list
        static public bool everyoneIsStay = true;  // is everyone stay?
        static public Tasks nextTask; // keeps track of game state
        static public List<string> previousList = new List<string>(new string[8]);

        public Game(CardTable c, List<Player> playersTemp) //add one more signature to pass the previous players who keeps playing
        {
            players = playersTemp; // overwrite the players

            cardTable = c; 
            deck.ShuffleCards(); // shuffle the cards

        }

        /* ********* ScoreHand() **********
         * Calculate the score player currently has in hand
         * Called by DoNextTask() method
         * INPUT: Player player --> the player whose cards we would like to calculate 
         * OUTPUT: int score ---> return the player's current total score
         */
        static public int ScoreHand(Player player)
        {
            int score = 0;

            foreach (Card card in player.cards) // check every card the player has one by one
            {
                int faceValue = card.CardValue; // calculate "numbers"

                switch (faceValue) //calculate "special numbers"
                {
                    case 13:
                    case 12:
                    case 11:
                        score = score + 10;
                        break;
                    case 1:
                        score = score + 1;
                        break;
                    default:
                        score = score + faceValue;
                        break;
                }
            }
           
            return score;
        }

        
    }
}
