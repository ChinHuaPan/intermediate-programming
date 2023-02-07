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
            Console.Write("How many players? ");
            string response = Console.ReadLine();
            int numberOfPlayers;
            while (int.TryParse(response, out numberOfPlayers) == false
                || numberOfPlayers < 2 || numberOfPlayers > 8)
            {
                Console.WriteLine("Invalid number of players.");
                Console.Write("How many players?");
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
            Console.Write("What is the name of player# " + playerNum + "? ");
            string response = Console.ReadLine();
            while (response.Length < 1)
            {
                Console.WriteLine("Invalid name.");
                Console.Write("What is the name of player# " + playerNum + "? ");
                response = Console.ReadLine();
            }
            return response;
        }

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
                    if (isFirst)
                    {
                        Console.Write(card.displayName);
                        isFirst = false;
                    }
                    else
                    {
                        Console.Write(", " + card.displayName);
                    }
                }
                Console.Write(" = " + player.score + "/21 ");
                if (player.status != PlayerStatus.active)
                {
                    Console.Write("(" + player.status.ToString().ToUpper() + ")");
                }
                Console.WriteLine();
            }
        }

        public void ShowHands(List<Player> players)
        {
            foreach (Player player in players)
            {
                ShowHand(player);
            }

                Console.WriteLine("-----");
            
        }


        public void AnnounceWinner(Player player)
        {
            if (player != null)
            {
                Console.WriteLine(player.name + " wins!");
            }
            else if (Game.everyOneIsStay)
            {
                Console.WriteLine("Come on, everyone...please be agressive!");
            }
            else
            {
                Console.WriteLine("Everyone busted!");
            }
            Console.Write("Play again...? (Y/N)");
            //while (Console.ReadKey().Key != ConsoleKey.Enter) {

                string response = Console.ReadLine();
                if (response.ToUpper().StartsWith("Y"))
                    {
                    CardTable cardTable = new CardTable();
                    Game game = new Game(cardTable);
                    while (game.nextTask != Task.GameOver)
                    {
                        game.DoNextTask();
                    }
                }
                else if (response.ToUpper().StartsWith("N"))
                {
                    return;
                }
            
        }

        public bool CheckBust(List<Player> players, int current)
        {
            bool otherAreBust = true;
            for(int i=0; i < players.Count; i++)
            {
                if(i != current)
                {
                    otherAreBust = otherAreBust && (players[i].status == PlayerStatus.bust);
                }
            }

            return otherAreBust;
        }

        public bool CheckStay(List<Player> players)
        {

            foreach (Player player in players)
            {
                    Game.everyOneIsStay = Game.everyOneIsStay && (player.status == PlayerStatus.stay);
            }

            return Game.everyOneIsStay;
        }
    }
}