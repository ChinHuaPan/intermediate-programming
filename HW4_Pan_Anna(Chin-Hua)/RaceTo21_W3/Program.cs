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

