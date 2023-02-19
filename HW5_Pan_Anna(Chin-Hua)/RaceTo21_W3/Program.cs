using System;
using System.Collections.Generic;

namespace RaceTo21
{
    class Program
    {
        static void Main(string[] args)
        {
            //CardTable cardTable = new CardTable();
            //Game game = new Game(cardTable);
            Deck deck = new Deck();
            List<Player> players = new List<Player>();

            deck.initializeGame(players);
        }
    }
}


/****************************************************************************************************
 * >>> LEVEL 1 ✅
 * Players only enter Y or N once, so discussion of continuing happens outside the game. 
 * If players choose to keep going, a new deck is built and shuffled. 
 * In addition, player list is shuffled, to ensure the same person doesn’t always win a tiebreaker.
 * 
 * >>> LEVEL 2 ✅
 * At end of round, each player is asked if they want to keep playing. 
 * If a player says no, they are removed from the player list. 
 * If only 1 player remains, that player is the winner 
 * (equivalent to everyone else “folding” in a card game).
 * 
 * >>> LEVEL 3 ✅
 * The previous round’s winner becomes the “dealer” (so they will go last in the new round), 
 * but other players are still shuffled so that turn order changes.
 * 
 * ▶ ▶ ▶ IN PROCESSS:
 * 1. Deal with the duplicated "*********** Building deck..."
 * 2. Create methods for the process of "check play agin or not" and "check keep playing" 
 * 
 ****************************************************************************************************/