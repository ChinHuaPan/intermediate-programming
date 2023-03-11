using System;
namespace ZooManager
{
    /////////////// 👉 Goal 3: create Alien  /////////////////
    public class Alien : IPredator
    {
        public Alien()
        {

        }
        public string emoji = "👽";
        public string name = "alien";
        public int reactionTime = 5; // default reaction time for animals (1 - 10)
        //public int distance;

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

        /*********** Activate() *************
        * Find out something to hunt, flee or do nothing, and return whether has a movement or not
        * Called by Game class
        * INPUT: none
        * OUTPUT: bool --> whether it has movement
        * **/
        virtual public bool Activate()
        {
            Console.WriteLine($"Alien {name} at {location.x},{location.y} activated");
            return false;
        }


        ///*********** Seek() *************
        // * Seek a particular target animal by checking direction in order
        // * Called by each animal classes
        // * INPUT: int x --> x of location
        // *        int y --> y of location
        // *        Direction direction --> the direction it would like to search
        // *        string target --> target animal
        // *        int distance --> search distance
        // * OUTPUT: int --> return the distance that it finds out a target animal, 0 means no result
        // * **/
        //static public int Seek(int x, int y, Direction direction, string target, int distance = 1) //give distance a temporary default value
        //{
        //    //go through every direction with distance
        //    for (int currentDistance = 1; currentDistance <= distance; currentDistance++)
        //    {
        //        switch (direction)
        //        {
        //            case Direction.up:
        //                y--;
        //                break;
        //            case Direction.down:
        //                y++;
        //                break;
        //            case Direction.left:
        //                x--;
        //                break;
        //            case Direction.right:
        //                x++;
        //                break;
        //        }

        //        if (y < 0 || x < 0 || y > Game.numCellsY - 1 || x > Game.numCellsX - 1) return 0;
        //        if (Game.animalZones[y][x].occupant == null) return 0;
        //        if (Game.animalZones[y][x].occupant.species == target)
        //        {
        //            return currentDistance;
        //        }
        //    }
        //    return 0;

        //}


        /*********** Attack() *************
        * Attack an target animal, replace it by attacker
        * Called by Hunt() method
        * INPUT: Animal attacker --> attacker animal
        *        Direction d --> attack direction
        * OUTPUT: bool --> return whether attack or not
        * **/
        //static public bool Attack(Animal attacker, Direction d)
        //{
        //    Console.WriteLine($"{attacker.name} is attacking {d.ToString()}");
        //    int x = attacker.location.x;
        //    int y = attacker.location.y;

        //    Game.animalZones[y][x].occupant = null; //remove the attacker from the current location

        //    //replace the animal which is hunted by attacker
        //    switch (d)
        //    {
        //        case Direction.up:
        //            Game.animalZones[y - 1][x].occupant = attacker;
        //            return true;
        //        case Direction.down:
        //            Game.animalZones[y + 1][x].occupant = attacker;
        //            return true;
        //        case Direction.left:
        //            Game.animalZones[y][x - 1].occupant = attacker;
        //            return true;
        //        case Direction.right:
        //            Game.animalZones[y][x + 1].occupant = attacker;
        //            return true;
        //    }
        //    return false;
        //}
    }
}
