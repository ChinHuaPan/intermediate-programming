using System;

namespace ZooManager
{
    public class Cat : Animal, IPredator, IPrey
    {
        public Cat(string name)
        {
            emoji = "🐱";
            species = "cat";
            this.name = name;
            reactionTime = new Random().Next(1, 6); // reaction time 1 (fast) to 5 (medium)
        }

        // cat's preys
        string[] preys = { "mouse", "chick" };

        /*********** Activate() *************
         * Find out something to hunt, flee or do nothing, and return whether has a movement or not
         * Called by Game class
         * INPUT: none
         * OUTPUT: bool --> whether it has movement
         * **/
        public override bool Activate()
        {
            base.Activate();
            Console.WriteLine("I am a cat. Meow.");


            if (Flee("rapter")) return true;
            if (Hunt(preys)) return true;
            return false;

        }

    }
}

