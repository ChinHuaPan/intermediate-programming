using System;
using System.Collections.Generic;

namespace RaceTo21Blazor
{
    public class Game
    {
        List<Player> players; // list of objects containing player data
        CardTable cardTable; // object in charge of displaying game information
        Deck deck = new Deck(); // deck of cards
        int currentPlayer = 0; // current player on list
        static public bool everyoneIsStay = true;  // is everyone stay?
        public Tasks nextTask; // keeps track of game state

        public Game(CardTable c, List<Player> playersTemp) //add one more signature to pass the previous players who keeps playing
        {
            players = playersTemp; // overwrite the players

            cardTable = c; 
            deck.Shuffle(); // shuffle the cards

            /* If it is the first round, go to get the player list,
             * if not, introduce the players directly
             * ***/
            if(playersTemp.Count == 0)
            {
                nextTask = Tasks.GetPlayerList;
            }
            else
            {
                nextTask = Tasks.IntroducePlayers;
            }
            
        }

        /* ******** AddPlayer() **********
         * Adds a player to the current game
         * Called by DoNextTask() method
         * INPUT: string name ---> the player we would like to add into the player list
         * OUTPUT: none
         */
        public void AddPlayer(string name)
        {
            players.Add(new Player(name));
        }

        /* ********* DoNextTask() **********
         * Run the game in different stages with tasks
         * Called by initializedGame() method
         * INPUT: none
         * OUTPUT: none
         */
        public void DoNextTask()
        {
            Console.WriteLine("================================");

            /* ******************************************************************
             * We use this condition to check the current task status
             * ******************************************************************/

            if (nextTask == Tasks.GetPlayerList) // do the task: get the player list from console
            {
                players = cardTable.GetPlayers(); // get player list
                nextTask = Tasks.IntroducePlayers; // change next task to introduce players
            }
            else if (nextTask == Tasks.IntroducePlayers) // introduce players
            {
                deck.shufflePlayers(players); // shuffle the players (to ensure the same person doesn’t always win a tiebreaker)
                cardTable.ShowPlayers(players); // show all players
                nextTask = Tasks.PlayerTurn; // change next task to player turns
            }
            else if (cardTable.CheckOthersBust(players, currentPlayer)) // if there is only one player doesn't bust
            {
                OverGame(); // game is over
            }
            else if (nextTask == Tasks.PlayerTurn) // player turns
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
                        else if (player.score == 21 || player.cards.Count == 5) // if score exactly hits 21 or the player already has 5 cards
                        {
                            player.status = PlayerStatus.win; // change the player's status to win
                            nextTask = Tasks.CheckForEnd;  // change next task to CheckForEnd

                            OverGame(); // game is over
                        }
                    }
                    else
                    {
                        player.status = PlayerStatus.stay; // change the player's status to stay
                    }
                }

                if(nextTask != Tasks.GameOver) // if game isn't over yet
                {
                    //cardTable.ShowHand(player);
                    nextTask = Tasks.CheckForEnd; // change next task to CheckForEnd
                }
                
            }
            else if (nextTask == Tasks.CheckForEnd) // check for end this round
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
                    nextTask = Tasks.PlayerTurn; // change next task to player turns
                }
            }
            else // we shouldn't get here...
            {
                Console.WriteLine("I'm sorry, I don't know what to do now!");
                nextTask = Tasks.GameOver; // change next task to game over
            }
        }

        /* ********* ScoreHand() **********
         * Calculate the score player currently has in hand
         * Called by DoNextTask() method
         * INPUT: Player player --> the player whose cards we would like to calculate 
         * OUTPUT: int score ---> return the player's current total score
         */
        public int ScoreHand(Player player)
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

        /* ********* CheckActivePlayers() **********
         * Check whether there is any player is active
         * Called by DoNextTask() method
         * INPUT: none
         * OUTPUT: bool --> if it's true, means that there is at least one active player
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

        /* ********* DoFinalScoring() **********
         * determine who is the winner
         * Called by DoNextTask() method
         * INPUT: none
         * OUTOUT: Player player ---> return the winner player
         */
        public Player DoFinalScoring()
        {
            int highScore = 0;

            foreach (var player in players) // check every player
            {
                cardTable.ShowHand(player);

                if (player.status == PlayerStatus.win) // someone hits 21
                {
                    return player;
                }
                if (player.status == PlayerStatus.stay) // still could win...
                {
                    //find out the highest score
                    if (player.score > highScore)
                    {
                        highScore = player.score;
                    }
                }
            }

            if (cardTable.CheckOthersBust(players, currentPlayer)) // check whether bust or not
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

        /* ********* OverGame() **********
         * Process the following things when a game is over
         * Called by DoNextTask() method
         * INPUT: none
         * OUTPUT: noen
         */
        public void OverGame()
        {
            Player winner = DoFinalScoring(); // pass the winner
            cardTable.AnnounceWinner(winner); // announce the winner
            List<Player> playersTemp; // create a new list of player named playersTemp

            if (cardTable.AskPlayAgain()) // if the players would like to play again
            {

                // This loop show the current players
                Console.WriteLine("The current players:");
                for (var count = 0; count < players.Count; count++)
                {
                    Console.Write(players[count].name + " "); 
                }

                // ask the players whether they would like to modify the player list
                playersTemp = cardTable.AskModifyPlayerList(players); 

                for (var index = 0; index < playersTemp.Count; index++) // show the players who keep playing
                {
                    Console.Write(playersTemp[index].name + ",");
                }
                    Console.Write(" join the next round!");

                Deck deck = new Deck(); // creat a deck
                deck.initializeGame(playersTemp); //initialize the game

            }
            nextTask = Tasks.GameOver; // change the next task to game over
        }
    }
}
