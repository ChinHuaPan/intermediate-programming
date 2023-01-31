using System;
namespace RaceTo21
{
	public class Deck
	{
		public Deck()
		{
		}

		/*** generateCards() ***
		 * Generate cards in order
		 * Called by: None
		 * INPUT: None
		 * Call object: None
		 * OUTPUT: None
		 * ***/
		public void generateCards()
		{
			
		}

		public string[] shuffledCards;

		/*** Shuffle() ***
		 * Shffle and random cards
		 * Called by: Game object
		 * INPUT: None
		 * Call object: None
		 * OUTPUT: None
		 * ***/
		public void Shuffle()
		{
			Console.WriteLine("Shuffling Cards...");
		}


		/*** ValueCards() ***
		 * Add up the corresponding values of cardNum string array, and return the total value
		 * Called by: Player object
		 * INPUT: string[] cardNum --> all the numbers of the cards that a player has
		 * Call abject: None
		 * OUTPUT: int totalValue --> the total value that the player has
		 * ***/
		public int ValueCards(string[] cardNum)
		{
			int totalValue = 0;

			return totalValue;
		}

		/*** TakeTopCard() ***
		 * Take the top of card and return it
		 * Called by: Player object
		 * INPUT: None
		 * Call object: None
		 * OUTPUT: string topCard --> return the top card
		 * ***/
		public string TakeTopCard()
        {
			string topCard = string.Empty;

			return topCard;
        }
	}
}

