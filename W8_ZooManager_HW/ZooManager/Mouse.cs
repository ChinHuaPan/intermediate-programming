using System;

namespace ZooManager
{
    public class Mouse : Animal, IPrey
    {
        public Mouse(string name)
        {
            emoji = "🐭";
            species = "mouse";
            this.name = name; // "this" to clarify instance vs. method parameter
            reactionTime = new Random().Next(1, 4); // reaction time of 1 (fast) to 3
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
            Console.WriteLine("I am a mouse. Squeak.");
            if(Flee("cat")) return true;
            return false;
        }

        /////////////// 👉 Goal #1: g/ create move method and modify mouse.flee()  /////////////////
        /*********** Flee() *************
         * Find out cat to flee
         * Called by: none
         * INPUT: none
         * OUTPUT: bool --> whether it has movement
         * **/
        public override bool Flee(string predator)
        {
            Random random = new Random();

            // get Enum values for the following steps
            // Reference: https://stackoverflow.com/questions/105372/how-to-enumerate-an-enum
            Array values = Enum.GetValues(typeof(Direction));

            // check every direction by foreach of Direction Enum
            foreach (Direction d in Enum.GetValues(typeof(Direction)))
            {
                if (Convert.ToBoolean(Animal.Seek(location.x, location.y, d, predator)))
                {
                    // Get a random value from the Direction enum
                    // Reference: https://stackoverflow.com/questions/3132126/how-do-i-select-a-random-value-from-an-enumeration

                    Move(this, (Direction)values.GetValue(random.Next(values.Length)), 2);

                    return true;
                }
                return false;
            }
            return false;
            
        }
    }
}

