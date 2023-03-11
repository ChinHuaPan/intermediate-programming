using System;
namespace ZooManager
{
    public class Animal : Creature
    {

        /////////////// 👉 o: fix multiple Activate()  /////////////////
        /*********** Activate() *************
         * Act a movement and return whether it has movement or not
         * Called by Game class
         * INPUT: none
         * OUTPUT: bool --> has movement or not
         * **/
        override public bool Activate()
        {
            Console.WriteLine($"Animal {name} at {location.x},{location.y} activated");
            return false;
        }

        /////////////// 👉 f: modify seek method /////////////////
        /*********** Seek() *************
         * Seek a particular target animal by checking direction in order
         * Called by each animal classes
         * INPUT: int x --> x of location
         *        int y --> y of location
         *        Direction direction --> the direction it would like to search
         *        string target --> target animal
         *        int distance --> search distance
         * OUTPUT: int --> return the distance that it finds out a target animal, 0 means no result
         * **/
        static public int Seek(int x, int y, Direction direction, string target, int distance = 1) //give distance a temporary default value
        {
            //go through every direction with distance
            for (int currentDistance = 1; currentDistance <= distance; currentDistance++)
            {
                switch (direction)
                {
                    case Direction.up:
                        y--;
                        break;
                    case Direction.down:
                        y++;
                        break;
                    case Direction.left:
                        x--;
                        break;
                    case Direction.right:
                        x++;
                        break;
                }

                if (y < 0 || x < 0 || y > Game.numCellsY - 1 || x > Game.numCellsX - 1) return 0;
                if (Game.creatureZones[y][x].occupant == null) return 0;
                if (Game.creatureZones[y][x].occupant.species == target)
                {
                    return currentDistance;
                }
            }
            return 0;

        }


    }
}
