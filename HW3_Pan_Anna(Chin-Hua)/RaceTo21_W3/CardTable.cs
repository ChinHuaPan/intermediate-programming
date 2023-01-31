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

        /*** ShowPlayers() ***
		 * hows the name of each player
		 * Called by: Game object, Game object provides list of players
		 * INPUT: List<Player> p --> 
		 * Call object: Player object, calls Introduce method on each player object
		 * OUTPUT: None
		 * ***/
        public void ShowPlayers(List<Player> p)
        {
            foreach (var player in p)
            {
                player.Introduce();
            }
        }

        /*** GetNumberOfPlayers() ***
		 * Gets the user input for number of players
		 * Called by: Game object
		 * INPUT:  None
		 * Call object: None
		 * OUTPUT: int numberOfPlayers --> Returns number of players to Game object
		 * ***/
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

        /*** GetPlayerName() ***
         * Gets the name of a player
         * Called by: Game object, Game object provides player number
         * INPUT:  None
         * Call object: None
         * OUTPUT: string response --> Returns name of a player to Game object
         * ***/
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

        /*** ShowWinner() ***
         * Campare the value and show the winner
         * Called by: Game object
         * INPUT:  List<int> valuesOfEachPlayers --> the values of each players
         * Call object: None
         * OUTPUT: string winner --> return the name of the winner
         * ***/
        public string ShowWinner(List<int> valuesOfEachPlayers)
        {
            string winner = string.Empty;


            return winner;
        }

        /*** DrawCard() ***
         * Campare the value and show the winner
         * Called by: Player object. requestCard()
         * INPUT: None
         * Call object: Deck object, takeTopCard()
         * OUTPUT: None
         * ***/
        public string DrawCard()
        {
            string topCard = string.Empty;

            return topCard;
        }

        /*** DisplayPlayersCards() ***
         * Display all players' cards
         * Called by: None
         * INPUT: List<Player> p --> all players
         * Call object: Player abject
         * OUTPUT: None
         * ***/
        public void DisplayPlayersCards(List<Player> p)
        {

        }
    }
}