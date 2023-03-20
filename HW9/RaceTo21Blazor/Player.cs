using System;
using System.Collections.Generic;

namespace RaceTo21Blazor
{
	public class Player
	{
		public string name;
		public List<Card> cards = new List<Card>();
		public PlayerStatus status = PlayerStatus.active;
		public int score;
		public OverReason winReason;

		public Player(string n)
		{
			name = n;
        }

		/* ********* Introduce() **********
		 * Introduces player by name
		 * Called by CardTable object
		 * INPUT: int playerNum ---> the order of players
		 * OUTPUT: none
		 */
		public void Introduce(int playerNum)
		{
			Console.WriteLine("Hello, my name is " + name + " and I am player #" + playerNum);
		}

	}
}

