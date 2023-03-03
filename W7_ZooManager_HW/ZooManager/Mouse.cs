using System;

namespace ZooManager
{
    public class Mouse : Animal
    {
        public Mouse(string name)
        {
            emoji = "🐭";
            species = "mouse";
            this.name = name; // "this" to clarify instance vs. method parameter
            reactionTime = new Random().Next(1, 4); // reaction time of 1 (fast) to 3
        }

        /////////////// 👉 o: fix multiple Activate()  /////////////////
        /*********** Activate() *************
         * Find out something to flee or do nothing, and return whether has a movement or not
         * Called by Game class
         * INPUT: none
         * OUTPUT: bool --> whether it has movement
         * **/
        public override bool Activate()
        {
            base.Activate();
            Console.WriteLine("I am a mouse. Squeak.");
            if(Flee()) return true;
            return false;
        }

        /*********** Flee() *************
         * Find out cat to flee
         * Called by: none
         * INPUT: none
         * OUTPUT: bool --> whether it has movement
         * **/
        public bool Flee()
        {
            if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.up, "cat")))
            {
                if (Animal.Retreat(this, Direction.down)) return true;
            }
            if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.down, "cat")))
            {
                if (Animal.Retreat(this, Direction.up)) return true;
            }
            if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.left, "cat")))
            {
                if (Animal.Retreat(this, Direction.right)) return true;
            }
            if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.right, "cat")))
            {
                if (Animal.Retreat(this, Direction.left)) return true;
            }
            return false;
        }
    }
}

