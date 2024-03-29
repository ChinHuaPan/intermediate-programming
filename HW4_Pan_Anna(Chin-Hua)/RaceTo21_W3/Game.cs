﻿using System;
using System.Collections.Generic;

namespace RaceTo21
{
    public class Game
    {
        int numberOfPlayers; // number of players in current game
        List<Player> players; // list of objects containing player data
        CardTable cardTable; // object in charge of displaying game information
        Deck deck = new Deck(); // deck of cards
        int currentPlayer = 0; // current player on list
        static public bool everyOneIsStay = true;
        public Task nextTask; // keeps track of game state
        private bool cheating = true; // lets you cheat for testing purposes if true
        Player lastWinner;

        public Game(CardTable c, List<Player> playersTemp)
        {
            // make changes to deal with the case of players as one of the inputs

            if (playersTemp.Count==1) {
                lastWinner= playersTemp[0];
                players = new List<Player>();
            }
            else
            {
                players = playersTemp;
            }
            cardTable = c;
            deck.Shuffle();
            deck.ShowAllCards();
            nextTask = Task.GetNumberOfPlayers;
        }

        /* Adds a player to the current game
         * Called by DoNextTask() method
         */
        public void AddPlayer(string name)
        {
            players.Add(new Player(name));
        }

        /* Figures out what task to do next in game
         * as represented by field nextTask
         * Calls methods required to complete task
         * then sets nextTask.
         */
        public void DoNextTask()
        {
            Console.WriteLine("================================"); // this line should be elsewhere right?
            if (nextTask == Task.GetNumberOfPlayers)
            {
                numberOfPlayers = cardTable.GetNumberOfPlayers();
                nextTask = Task.GetNames;
            }
            else if (nextTask == Task.GetNames)
            {
                for (var count = 1; count <= numberOfPlayers; count++)
                {
                    var name = cardTable.GetPlayerName(count);
                    AddPlayer(name); // NOTE: player list will start from 0 index even though we use 1 for our count here to make the player numbering more human-friendly
                }
                deck.shufflePlayers(players);
                if (lastWinner != null)
                {
                    players.Add(lastWinner);
                }
                nextTask = Task.IntroducePlayers;
            }
            else if (nextTask == Task.IntroducePlayers)
            {
                cardTable.ShowPlayers(players);
                nextTask = Task.PlayerTurn;
            }
            else if (cardTable.CheckBust(players, currentPlayer))
            {
                OverGame();
            }
            else if (nextTask == Task.PlayerTurn)
            {
                cardTable.ShowHands(players);
                Player player = players[currentPlayer];
                if (player.status == PlayerStatus.active)
                {
                   if (cardTable.OfferACard(player))
                    {
                        Card card = deck.DealTopCard();
                        player.cards.Add(card);
                        player.score = ScoreHand(player);
                        if (player.score > 21)
                        {
                            player.status = PlayerStatus.bust;
                        }
                        else if (player.score == 21)
                        {
                            player.status = PlayerStatus.win;
                            nextTask = Task.CheckForEnd;

                            OverGame();
                        }
                    }
                    else
                    {
                        player.status = PlayerStatus.stay;
                    }
                }

                if(nextTask != Task.GameOver)
                {
                    //cardTable.ShowHand(player);
                    nextTask = Task.CheckForEnd;
                }
                
            }
            else if (nextTask == Task.CheckForEnd)
            {
                if (!CheckActivePlayers())
                {
                    //Player winner = DoFinalScoring();
                    //cardTable.AnnounceWinner(winner);
                    //nextTask = Task.GameOver;
                    cardTable.CheckStay(players);
                    OverGame();
                }
                else
                {
                    currentPlayer++;
                    if (currentPlayer > players.Count - 1)
                    {
                        currentPlayer = 0; // back to the first player...
                    }
                    nextTask = Task.PlayerTurn;
                }
            }
            else // we shouldn't get here...
            {
                Console.WriteLine("I'm sorry, I don't know what to do now!");
                nextTask = Task.GameOver;
            }
        }

        public int ScoreHand(Player player)
        {
            int score = 0;
            if (cheating == true && player.status == PlayerStatus.active)
            {
                string response = null;
                while (int.TryParse(response, out score) == false)
                {
                    Console.Write("OK, what should player " + player.name + "'s score be?");
                    response = Console.ReadLine();
                }
                return score;
            }
            else
            {
                foreach (Card card in player.cards)
                {
                    string faceValue = card.id.Remove(card.id.Length-1);
                    switch (faceValue)
                    {
                        case "K":
                        case "Q":
                        case "J":
                            score = score + 10;
                            break;
                        case "A":
                            score = score + 1;
                            break;
                        default:
                            score = score + int.Parse(faceValue);
                            break;
                    }
                }
            }
            return score;
        }

        public bool CheckActivePlayers()
        {
            foreach (var player in players)
            {
                if (player.status == PlayerStatus.active && player.status != PlayerStatus.win)
                {
                    return true; // at least one player is still going!
                }
            }
            return false; // everyone has stayed or busted, or someone won!
        }

        public Player DoFinalScoring()
        {
            int highScore = 0;
            foreach (var player in players)
            {
                cardTable.ShowHand(player);
                if (player.status == PlayerStatus.win) // someone hit 21
                {
                    return player;
                }
                if (player.status == PlayerStatus.stay) // still could win...
                {
                    if (player.score > highScore)
                    {
                        highScore = player.score;
                    }
                }
                
                // if busted don't bother checking!
            }

            if (cardTable.CheckBust(players, currentPlayer))
            {
                highScore = players[currentPlayer].score;
                return players[currentPlayer];
            }

            if (highScore > 0) // someone scored, anyway!
            {
                // find the FIRST player in list who meets win condition
                return players.Find(player => player.score == highScore);
            }

            return null; // everyone must have busted because nobody won!
        }

        public void OverGame()
        {
            Player winner = DoFinalScoring();
            cardTable.AnnounceWinner(winner);
            if (cardTable.AskPlayAgain())
            {
                List<Player> playersTemp = new List<Player>();

                for (var count = 0; count < numberOfPlayers; count++)
                {
                    if (cardTable.AskKeepPlaying(players[count].name))
                    {
                        playersTemp.Add(new Player(players[count].name));
                    }
                }

                if (playersTemp.Count == 1)
                {
                    cardTable.AnnounceWinner(playersTemp[0]);

                }
                Console.WriteLine(playersTemp[0].name + " joins the next round!");
                Deck deck = new Deck();
                deck.initializeGame(playersTemp);


            }
            nextTask = Task.GameOver;
        }
    }
}
