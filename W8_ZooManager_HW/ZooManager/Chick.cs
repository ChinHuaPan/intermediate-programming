/////////////// 👉 c: create a chick /////////////////
using System;
namespace ZooManager
{
    public class Chick : Bird, IPrey
    {
        public Chick(string name)
        {
            emoji = "🐥";
            species = "mouse";
            this.name = name; // "this" to clarify instance vs. method parameter
            reactionTime = new Random().Next(6, 10); // reaction time of 6 (fast) to 10

        }

        /*********** Activate() *************
         * Find out something to flee or do nothing, and return whether has a movement or not
         * Called by Game class
         * INPUT: none
         * OUTPUT: bool --> whether it has movement
         * **/
        public override bool Activate()
        {
            base.Activate();
            Console.WriteLine("I am a chick. Cluck.");
            if(Flee("cat")) return true;
            return false;
        }

        
    }
}
