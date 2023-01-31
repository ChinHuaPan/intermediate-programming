using System;
namespace RaceTo21
{
	public class Player
	{
		string name;

		public Player(string n)
		{
			name = n;
		}


		/*** Introduce() ***
		 * Introduces player by name
		 * Called by: CardTable object
		 * INPUT: None
		 * Call object: None
		 * OUTPUT: None
		 * ***/
		public void Introduce()
		{
			Console.WriteLine("Hello, my name is " + name);
		}

		/*** RequestCard() ***
		 * Refresh the cards after a player requests a new card (add the new card into the current player)
		 * Called by: None
		 * INPUT: string[] playerCards --> all cards that the player has currently
		 * Call abject: Deck object
		 * OUTPUT: string[] cardRefreshed --> refreshed cards
		 * ***/
		public string[] RequestCard(string[] playerCards)
        {
			string[] cardRefreshed = new string[0]; //all cards that a player has

			return cardRefreshed;
        }

		public string[] frozenPlayers; //array of the players who are frozen

		/*** Stay() ***
		 * Mark the current players who would like to stay and would be frozen in the following rounds
		 * Called by: Game object
		 * INPUT: string currentPlayer --> add the current player to the forzen array
		 * Call abject: None
		 * OUTPUT: None
		 * ***/
		public void stay(string currentPlayer)
        {

        }

		/*** displayCards() ***
		 * Display the cards the player has
		 * Called by: CardTable object
		 * INPUT: string currentPlayer --> add the current player to the forzen array
		 * Call abject: None
		 * OUTPUT: None
		 * ***/
		public void displayCards(string currentPlayer)
        {

        }
	}
}

