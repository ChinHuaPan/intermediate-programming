using System;
using System.Collections.Generic;

namespace RaceTo21Blazor
{
    public class CardTable
    {
        public CardTable()
        {
            Console.WriteLine("Setting Up Table...");
        }

        /* ********* ShowPlayers() **********
         * Shows the name of each player and introduces them by table position.
         * Is called by Game object.
         * Game object provides list of players.
         * Calls Introduce method on each player object.
         * INPUT: List<Player> players ---> the player list
         * OUTPUT: none
         */
        public void ShowPlayers(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                players[i].Introduce(i + 1); // List is 0-indexed but user-friendly player positions would start with 1...
            }
        }

        /* ********* GetPlayers() **********
         * Get player list from console
         * INPUT: none
         * OUTPUT: List<Player> inputPlayers --> the player list that the player typed
         * **/
        public List<Player> GetPlayers()
        {
            Console.WriteLine("Please input player names: \n (2 to 8 names, separate with space) \n (We will shuffle your orders in the game!)");

            List<Player> inputPlayers = new List<Player>();
            string[] playerNames;

            while (true)
            {
                //TODO:read
                string response = "2 adf"; // read from console

                // Use TrimStart() and TrimEnd() to remove "space" in the response
                // Reference: https://stackoverflow.com/questions/3381952/how-to-remove-all-white-space-from-the-beginning-or-end-of-a-string
                playerNames = response.TrimStart().TrimEnd().Split(" ");

                // if the number of players is invalid
                if (playerNames.Length <= 1 || playerNames.Length > 8)
                {
                    Console.WriteLine("Please just input 2 to 8 player names!");
                }
                else
                {
                    break;
                }
            }

            // create player with name
            for (int i = 0; i < playerNames.Length; i++)
            {
                inputPlayers.Add(new Player(playerNames[i]));
            }

            return inputPlayers;
        }

        /* ********* OfferACard() **********
         * Offer a card when a player request
         * Called by Game object
         * INPUT: Player player ---> the player list
         * OUTPUT: bool
         */
        public bool OfferACard(Player player)
        {
            while (true)
            {
                Console.Write(player.name + ", do you want a card? (Y/N)");
                //TODO:ask someone if he wants a card
                string response = "y";

                if (response.ToUpper().StartsWith("Y"))
                {
                    return true;
                }
                else if (response.ToUpper().StartsWith("N"))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please answer Y(es) or N(o)!");
                }
            }
        }

        /* ********* ShowHand() **********
         * Show a card or status
         * Called by ShowHands method
         * INPUT: Player player ---> the current player
         * OUTPUT: none
         */
        public void ShowHand(Player player)
        {

            if (player.cards.Count > 0)
            {
                Console.Write(player.name + " has: ");

                //if it's the first one, we won't give it a comma
                //I figured out this way and was inspired by this solution: https://stackoverflow.com/questions/43021/how-do-you-get-the-index-of-the-current-iteration-of-a-foreach-loop
                var isFirst = true;
                foreach (Card card in player.cards)
                {
                    if (isFirst) // it's the first one
                    {
                        Console.Write(card.Name); // show the name directly
                        isFirst = false; // change isFirst to false
                    }
                    else
                    {
                        Console.Write(", " + card.Name); // show the name with a comma
                    }
                }
                Console.Write(" = " + player.score + "/21 "); // show score

                if (player.status != PlayerStatus.active) // if the player's status is not active
                {
                    Console.Write("(" + player.status.ToString().ToUpper() + ")"); // show the player's status
                }
                Console.WriteLine();
            }
        }


        /* ********* ShowHands() **********
         * Show all the cards the player has
         * Called by Game object
         * INPUT: List<Player> players ---> player list
         * OUTPUT: none
         * */
        public void ShowHands(List<Player> players)
        {
            foreach (Player player in players)
            {
                ShowHand(player); // show card or status
            }

            Console.WriteLine("-----");

        }

        /* ********* AnnounceWinner() **********
         * Announce the winner and show the win reason
         * Called by Game object
         * INPUT: Player player ---> the winner player
         * OUTPUT: none
         */
        public void AnnounceWinner(Player player)
        {
            if (player != null) // if there is abviously a winner
            {
                // show the win reason based on different conditions
                if (player.score == 21) // is the player hits 21
                {
                    Console.WriteLine(player.name + " hits 21!");
                }
                else if (player.cards.Count == 5) // if the player has already 5 cards
                {
                    Console.WriteLine(player.name + " has 5 cards and haven't bustted yet!");
                }
                else if (Game.everyoneIsStay) // if everyone stay, someone who has the highest score is the winner
                {
                    Console.WriteLine(player.name + " has the highest score and others stay!");
                }
                else // someone hasn't bustted and has the highest score, he/she is the winner
                {
                    Console.WriteLine(player.name + " has the highest score and others bust!");
                }

            }
            else if (Game.everyoneIsStay) // if everyone is stay
            {
                Console.WriteLine("Come on, everyone...please be agressive!");
            }
            else // if everyone is bust
            {
                Console.WriteLine("Everyone busted!");
            }

        }

        /* ********* CheckOthersBust() **********
         * Check others are bust or not
         * Called by Game object
         * INPUT: List<Player> players ---> player list
         *        int current ---> the current player
         * OUTPUT: bool otherAreBust --> others are bust or not
         */
        public bool CheckOthersBust(List<Player> players, int current)
        {
            bool othersAreBust = true;

            for (int i = 0; i < players.Count; i++)
            {
                if (i != current)
                {
                    // default value of otherAreBust is TRUE
                    // thus, if there is any FALSE to && otherAreBust will be FALSE
                    // if (players[i].status == PlayerStatus.bust) is FALSE, that means the one is not bust
                    othersAreBust = othersAreBust && (players[i].status == PlayerStatus.bust);
                }
            }

            return othersAreBust;
        }

        /* ********* CheckEveryoneStay() **********
         * Check whether everyone is stay or not
         * Called by Game object
         * INPUT: List<Player> players ---> the player list
         * OUTPUT: bool Game.everyoneIsStay ---> everyone stay or not
         */
        public bool CheckEveryoneStay(List<Player> players)
        {

            foreach (Player player in players) // check every players
            {
                // default value of everyoneIsStay is TRUE
                // thus, if there is any FALSE to && everyoneIsStay will be FALSE
                // if (player.status == PlayerStatus.stay) is FALSE, that means the one is not stay
                Game.everyoneIsStay = Game.everyoneIsStay && (player.status == PlayerStatus.stay);
            }

            return Game.everyoneIsStay;
        }


        /* ********* AskPlayAgain() **********
         * Ask the players whether to play again or not
         * Called by Game object
         * INPUT: none
         * OUTPUT: bool
         */
        public bool AskPlayAgain()
        {
            Console.Write("Play again...? (Y/N)");

            while (true)
            {
                //TODO:play again?
                string response = "y";

                if (response.ToUpper().StartsWith("Y")) // if the player says yes
                {
                    return true;

                }
                else if (response.ToUpper().StartsWith("N")) // if the player says no
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please answer Y(es) or N(o)!"); // if the player respond invalid answer
                }
            }

        }

        /* ********* AskPlayAgain() **********
         * Ask the players whether to modify the player list
         * Called by Game object
         * INPUT: List<Player> players --> the current player list
         * OUTPUT: List<Player> playersTemp ---> the modified player list or origianl player list
         */
        public List<Player> AskModifyPlayerList(List<Player> players)
        {
            Console.WriteLine("\nIf you want to modify, just input your new player list:");

            string response;
            string[] playerNames;
            List<Player> playersTemp = new List<Player>(); // create a new list of player named playersTemp

            while (true)
            {
                //TODO:ask modify player list
                response = "haha, good";

                // Use TrimStart() and TrimEnd() to remove "space" in the response
                // Reference: https://stackoverflow.com/questions/3381952/how-to-remove-all-white-space-from-the-beginning-or-end-of-a-string
                playerNames = response.TrimStart().TrimEnd().Split(" ");

                // if the response is invalid
                if (response != string.Empty && (playerNames.Length <= 1 || playerNames.Length > 8))
                {
                    Console.WriteLine("Please just input 2 to 8 player names!");
                }
                else
                {
                    break;
                }
            }

            // if the response has value
            if (response != string.Empty)
            {
                // loop to add new players into playersTemp
                for (int i = 0; i < playerNames.Length; i++)
                {
                    playersTemp.Add(new Player(playerNames[i]));
                }

            }
            else
            {
                // loop to add current players into playersTemp (rebuild)
                for (int i = 0; i < players.Count; i++)
                {
                    playersTemp.Add(new Player(players[i].name));
                }
            }

            return playersTemp;
        }
    }
}