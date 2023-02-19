using System;
using System.Collections.Generic;

namespace RaceTo21
{
    public class CardTable
    {
        public CardTable()
        {
            Console.WriteLine("Setting Up Table...");
        }

        /* Shows the name of each player and introduces them by table position.
         * Is called by Game object.
         * Game object provides list of players.
         * Calls Introduce method on each player object.
         */
        public void ShowPlayers(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                players[i].Introduce(i+1); // List is 0-indexed but user-friendly player positions would start with 1...
            }
        }

        /* Gets the user input for number of players.
         * Is called by Game object.
         * Returns number of players to Game object.
         */
        public int GetNumberOfPlayers()
        {
            Console.Write("How many players want to join? ");
            string response = Console.ReadLine();
            int numberOfPlayers;
            while (int.TryParse(response, out numberOfPlayers) == false
                || numberOfPlayers < 2 || numberOfPlayers > 8)
            {
                Console.WriteLine("Invalid number of players.");
                Console.Write("How many players want to join?");
                response = Console.ReadLine();
            }
            return numberOfPlayers;
        }

        /* Gets the name of a player
         * Is called by Game object
         * Game object provides player number
         * Returns name of a player to Game object
         */
        public string GetPlayerName(int playerNum)
        {
            Console.Write("What is the name of joining player #" + playerNum + "? ");
            string response = Console.ReadLine();
            while (response.Length < 1)
            {
                Console.WriteLine("Invalid name.");
                Console.Write("What is the name of joining player #" + playerNum + "? ");
                response = Console.ReadLine();
            }
            return response;
        }

        // Offer a card when a player request
        // Called by Game object
        public bool OfferACard(Player player)
        {
            while (true)
            {
                Console.Write(player.name + ", do you want a card? (Y/N)");
                string response = Console.ReadLine();
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

        // Show a card or status
        // Called by ShowHands method
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

        // Show all the cards the player has
        // Called by Game object
        public void ShowHands(List<Player> players)
        {
            foreach (Player player in players)
            {
                ShowHand(player); // show card or status
            }

                Console.WriteLine("-----");
            
        }

        // Announce the winner
        // Called by Game object
        public void AnnounceWinner(Player player)
        {
            if (player != null) // if there is abviously a winner
            {
                if (player.score == 21)
                {
                    Console.WriteLine(player.name + " hits 21!");
                }else if (player.cards.Count >= 5)
                {
                    Console.WriteLine(player.name + " has 5 cards and haven't bustted yet!");
                }
                else if (Game.everyoneIsStay)
                {
                    Console.WriteLine(player.name + " has the highest score and others have stayed!");
                }
                else
                {
                    Console.WriteLine(player.name + " has the highest score and others have bustted!");
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

        //check others are bust or not
        //called by Game object
        public bool CheckOthersBust(List<Player> players, int current)
        {
            bool otherAreBust = true;

            for(int i=0; i < players.Count; i++)
            {
                if(i != current)
                {
                    // default value of otherAreBust is TRUE
                    // thus, if there is any FALSE to && otherAreBust will be FALSE
                    // if (players[i].status == PlayerStatus.bust) is FALSE, that means the one is not bust
                    otherAreBust = otherAreBust && (players[i].status == PlayerStatus.bust);
                }
            }

            return otherAreBust;
        }

        //check whether everyone is stay or not
        //called by Game object
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

        // Ask the players whether to play again or not
        // Called by Game object
        public bool AskPlayAgain()
        {
            Console.Write("Play again...? (Y/N)");

            while (true) {
                string response = Console.ReadLine();

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

        // Ask the player whether to keep playing or not
        // Called by Game object
        public bool AskKeepPlaying(string playerName)
        {
            Console.Write("Hey, " + playerName + "! Do you want to keep playing? (Y/N)");
            string response = Console.ReadLine();

            while (true) {
                if (response.ToUpper().StartsWith("Y")) // if the player says yes
                {
                    Console.WriteLine("That's great!");
                    return true;

                }
                else if (response.ToUpper().StartsWith("N")) // if the player says no
                {
                    Console.WriteLine("What a pity!");
                    return false;

                }
                else
                {
                    Console.WriteLine("Please answer Y(es) or N(o)!"); // if the player respond invalid answer
                }
            }

        }
    }
}