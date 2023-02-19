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
 * When game ends, ask the players whether would like to play again or not. 
 * If yes, initialize the game.
 * 
 * >>> LEVEL 1 ✅
 * The player list will be shuffled at first to make this game always is fair
 * 
 * >>> LEVEL 1 ✅
 * Add one more win condition: If someone get 5 cards and doesn't bust, the player wins.
 * 
 * >>> LEVEL 2 ✅
 * If a game ends and everyone decide to play again, they can add or remove any players from the list
 * 
 * ▶ ▶ ▶ IN PROCESSS:
 * 1. Deal with the duplicated "*********** Building deck..."
 * 2. Create methods for the process of "check play agin or not" and "check keep playing" 
 * 3. What is "CheckForEnd"
 * $. Input player names with multiple spaces in between
 ****************************************************************************************************/