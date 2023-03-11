using System;
namespace ZooManager
{
    public class Creature
    {
        public Creature()
        {
        }

        public string emoji;
        public string species;
        public string name;
        public int reactionTime = 5; // default reaction time for animals (1 - 10)
        public int distance;

        public Point location;

        /*********** ReportLocation() *************
        * Report the current location
        * Called by Game class
        * INPUT: none
        * OUTPUT: none
        * **/
        public void ReportLocation()
        {
            Console.WriteLine($"I am at {location.x},{location.y}");
        }


        /////////////// 👉 o: fix multiple Activate()  /////////////////
        /*********** Activate() *************
         * Act a movement and return whether it has movement or not
         * Called by Game class
         * INPUT: none
         * OUTPUT: bool --> has movement or not
         * **/
        virtual public bool Activate()
        {
            
            return false;
        }

    }
}
