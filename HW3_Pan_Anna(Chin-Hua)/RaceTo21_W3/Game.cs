using System;
using System.Collections.Generic;

namespace RaceTo21
{
    public class Game
    {
        int numberOfPlayers; // number of players in current game
        List<Player> players = new List<Player>(); // list of objects containing player data
        CardTable cardTable; // object in charge of displaying game information
        Deck deck = new Deck(); // deck of cards
        public string nextTask; // keeps track of game state

        public Game(CardTable c)
        {
            cardTable = c;
            deck.Shuffle();
            nextTask = "GetNumberOfPlayers";
        }

        /* Adds a player to the current game
         * Called by DoNextTask() method
         */
        public void AddPlayer(string n)
        {
            players.Add(new Player(n));
        }

        /* Figures out what task to do next in game
         * as represented by field nextTask
         * Calls methods required to complete task
         * then sets nextTask.
         */
        public void DoNextTask()
        {
            if (nextTask == "GetNumberOfPlayers")
            {
                numberOfPlayers = cardTable.GetNumberOfPlayers();
                nextTask = "GetNames";
            } else if (nextTask == "GetNames")
            {
                for (var count = 1; count <= numberOfPlayers; count++)
                {
                    var name = cardTable.GetPlayerName(count);
                    AddPlayer(name);
                }
                nextTask = "IntroducePlayers";
            } else if (nextTask == "IntroducePlayers")
            {
                cardTable.ShowPlayers(players);
                nextTask = "PlayerTurn";
            } else
            {
                Console.WriteLine("I'm sorry, I don't know what to do now!");
                nextTask = "GameOver";
            }
        }
    }

}

