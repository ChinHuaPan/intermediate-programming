using System;
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
        static public bool everyoneIsStay = true;  // is everyone stay?
        public Task nextTask; // keeps track of game state
        private bool cheating = false; // lets you cheat for testing purposes if true
        Player previousWinner; // the previous winner

        public Game(CardTable c, List<Player> playersTemp) //add one more signature to pass the previous players who keeps playing
        {
            // if there is only one previous player
            if (playersTemp.Count == 1)
            {
                previousWinner = playersTemp[0]; // pass the one to previousWinner
                players = new List<Player>(); // create a new List of Player
            }
            else // there are more than one previous player would like to keep playing
            {
                players = playersTemp; // overwrite the players
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
            Console.WriteLine("================================"); // this line should be elsewhere right? Um...I haven't figure out yet.

            if (nextTask == Task.GetNumberOfPlayers) // do the task: get number of players
            {
                numberOfPlayers = cardTable.GetNumberOfPlayers();
                nextTask = Task.GetNames;
            }
            else if (nextTask == Task.GetNames) // do the task: get names of players
            {
                for (var count = 1; count <= numberOfPlayers; count++)
                {
                    var name = cardTable.GetPlayerName(count);
                    AddPlayer(name); // NOTE: player list will start from 0 index even though we use 1 for our count here to make the player numbering more human-friendly
                }

                deck.shufflePlayers(players); // shuffle the players (to ensure the same person doesn’t always win a tiebreaker)

                if (previousWinner != null) // if there is a previous winner
                {
                    players.Add(previousWinner); // add previous winner to the player list (become "dealer")
                }

                nextTask = Task.IntroducePlayers; // change next task to introduce layers
            }
            else if (nextTask == Task.IntroducePlayers) // introduce players
            {
                cardTable.ShowPlayers(players);
                nextTask = Task.PlayerTurn; // change next task to player turns
            }
            else if (cardTable.CheckOthersBust(players, currentPlayer)) // if there is only one player isn't bust
            {
                OverGame(); // game is over
            }
            else if (nextTask == Task.PlayerTurn) // player turns
            {
                cardTable.ShowHands(players); // show the player's cards
                Player player = players[currentPlayer]; // pass current player

                if (player.status == PlayerStatus.active) // if the curretn player's status is active
                {
                   if (cardTable.OfferACard(player)) // if the current player request a card
                    {
                        Card card = deck.DealTopCard(); // pass the top card
                        player.cards.Add(card); // give the top card to the current player
                        player.score = ScoreHand(player); // calculate score the player has

                        if (player.score > 21) // if score is more than 21 --> bust
                        {
                            player.status = PlayerStatus.bust; // change the player's status to bust
                        }
                        else if (player.score == 21) // if score exactly hits 21
                        {
                            player.status = PlayerStatus.win; // change the player's status to win
                            nextTask = Task.CheckForEnd;  // change next task to CheckForEnd

                            OverGame(); // game is over
                        }
                    }
                    else
                    {
                        player.status = PlayerStatus.stay; // change the player's status to stay
                    }
                }

                if(nextTask != Task.GameOver) // if game isn't over yet
                {
                    //cardTable.ShowHand(player);
                    nextTask = Task.CheckForEnd; // change next task to CheckForEnd
                }
                
            }
            else if (nextTask == Task.CheckForEnd) // check for end this round
            {
                if (!CheckActivePlayers()) // if there is no active players
                {
                    cardTable.CheckEveryoneStay(players); // check whether everyone is stay or not
                    OverGame(); // game is over
                }
                else // game continues...
                {
                    currentPlayer++; // index moves on 

                    if (currentPlayer > players.Count - 1) // if the current index is out of the range of the length of list 
                    {
                        currentPlayer = 0; // back to the first player...
                    }
                    nextTask = Task.PlayerTurn; // change next task to player turns
                }
            }
            else // we shouldn't get here...
            {
                Console.WriteLine("I'm sorry, I don't know what to do now!");
                nextTask = Task.GameOver; // change next task to game over
            }
        }

        /* Calculate the score player currently has in hand
         * Called by DoNextTask() method
         */
        public int ScoreHand(Player player)
        {
            int score = 0;

            if (cheating == true && player.status == PlayerStatus.active) // if in cheat mode
            {
                string response = null;
                while (int.TryParse(response, out score) == false)
                {
                    Console.Write("OK, what should player " + player.name + "'s score be?");
                    response = Console.ReadLine();
                }
                return score;
            }
            else //normal mode
            {
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
            }
            return score;
        }

        /* Check whether there is any player is active
         * Called by DoNextTask() method
         */
        public bool CheckActivePlayers()
        {
            foreach (var player in players) // check every player
            {
                // if the player is active and doesn't win yet
                if (player.status == PlayerStatus.active && player.status != PlayerStatus.win)
                {
                    return true; // at least one player is still going!
                }
            }
            return false; // everyone has stayed or busted, or someone won!
        }

        /* determine who is the winner
         * Called by DoNextTask() method
         */
        public Player DoFinalScoring()
        {
            int highScore = 0;

            foreach (var player in players) // check every player
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

            if (cardTable.CheckOthersBust(players, currentPlayer)) // check whether are bust or not
            {
                highScore = players[currentPlayer].score; // pass current player's score to highScore
                return players[currentPlayer]; // current player is the winner
            }

            if (highScore > 0) // someone scored, anyway!
            {
                // find the FIRST player in list who meets win condition
                return players.Find(player => player.score == highScore);
            }

            return null; // everyone must have busted because nobody won!
        }

        /* Process the following things when a game is over
         * Called by DoNextTask() method
         */
        public void OverGame()
        {
            Player winner = DoFinalScoring(); // pass the winner
            cardTable.AnnounceWinner(winner); // announce the winner

            if (cardTable.AskPlayAgain()) // if the players would like to play again
            {
                List<Player> playersTemp = new List<Player>(); // create a new list of player named playersTemp

                // ask every player to keep playing or not
                for (var count = 0; count < numberOfPlayers; count++)
                {
                    if (cardTable.AskKeepPlaying(players[count].name)) // if the player agrees to keep playing
                    {
                        playersTemp.Add(new Player(players[count].name)); // add to the new playerTemp list
                    }
                }

                if (playersTemp.Count == 1) // if there is only one player would like to keep playing
                {
                    cardTable.AnnounceWinner(playersTemp[0]); // the player wins immediately

                }

                for (var index = 0; index < playersTemp.Count; index++) // show the players who keep playing
                {
                    Console.WriteLine(playersTemp[index].name + " joins the next round!");
                }

                Deck deck = new Deck(); // creat a deck
                deck.initializeGame(playersTemp); //initialize the game


            }
            nextTask = Task.GameOver; // change the next task to game over
        }
    }
}
