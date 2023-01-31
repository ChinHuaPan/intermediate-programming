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


        /*** AddPlayer() ***
		 * Adds a player to the current game
		 * Called by: DoNextTask() method
		 * INPUT: string n --> number of players
		 * Call object: None
		 * OUTPUT: None
		 * ***/
        public void AddPlayer(string n)
        {
            players.Add(new Player(n));
        }

        /*** DoNextTask() ***
		 * Figures out what task to do next in game, then sets nextTask.
		 * Called by: as represented by field nextTask
		 * INPUT: string n --> number of players
		 * Call object: Calls methods required to complete task
		 * OUTPUT: None
		 * ***/
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


        /*** GetPlayersName() ***
		 * Get names of the players
		 * Called by: None
		 * INPUT: None
		 * Call object: None
		 * OUTPUT: List<Player> players
		 * ***/
        public List<Player> GetPlayersName()
        {

            return players;
        }

        /*** TurnNextPlayer() ***
		 * Turn to the next player
		 * Called by: None
		 * INPUT: None
		 * Call object: None
		 * OUTPUT: None
		 * ***/
        public void TurnNextPlayer()
        {

        }

        /*** CheckWinOrBurst() ***
		 * Check whether any player bursts of wins
		 * Called by: None
		 * INPUT: None
		 * Call object: None
		 * OUTPUT: None
		 * ***/
        public void CheckWinOrBurst()
        {

        }

        /*** CheckGameOver() ***
		 * Check whether the game is over or not and final scoring
		 * Called by: None
		 * INPUT: None
		 * Call object: CheckWinOrBurst()
		 * OUTPUT: None
		 * ***/
        public void CheckGameOver()
        {

        }

    }

}

