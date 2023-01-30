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

		/* Introduces player by name
		 * Called by CardTable object
		 */
		public void Introduce()
		{
			Console.WriteLine("Hello, my name is " + name);
		}
	}
}

