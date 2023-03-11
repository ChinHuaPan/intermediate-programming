using System;
namespace ZooManager
{
    public class Raptor : Bird, IPredator
    {
        public Raptor(string name)
        {
            emoji = "🦅";
            species = "raptor";
            this.name = name;
            reactionTime = 1; // reaction time 1 (fast) to 5 (medium)
        }

        //raptor's preys
        //************** but it seems not work, need to check
        string[] preys = { "cat", "mouse" };

        /*********** Activate() *************
         * Find out something to hunt or do nothing and return whether has a movement or not
         * Called by Game class
         * INPUT: none
         * OUTPUT: bool --> whether it has movement
         * **/
        public override bool Activate()
        {
            base.Activate();
            Console.WriteLine("I am a raptor.");
            if (Hunt(preys)) return true;
            return false;
        }
    }
}
