using System;
namespace ZooManager
{
    public class Animal : Creature
    {

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

        /*********** Hunt() *************
         * Find out cat or mouse to hunt or do nothing
         * Called by: none
         * INPUT: none
         * OUTPUT: bool --> whether it hunt or not
         * **/
        public bool Hunt(string[] preys)
        {
            for (int i = 0; i < preys.Length; i++)
            {
                if (Convert.ToBoolean(Seek(location.x, location.y, Direction.up, preys[i])))
                {
                    if (Attack(this, Direction.up))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Seek(location.x, location.y, Direction.down, preys[i])))
                {
                    if (Attack(this, Direction.down))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Seek(location.x, location.y, Direction.left, preys[i])))
                {
                    if (Attack(this, Direction.left))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Seek(location.x, location.y, Direction.right, preys[i])))
                {
                    if (Attack(this, Direction.right))
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        /*********** Flee() *************
         * Find out raptor to flee
         * Called by: none
         * INPUT: none
         * OUTPUT: bool --> whether it has movement
         * **/
        virtual public bool Flee(string predator)
        {
            if (Convert.ToBoolean(Seek(location.x, location.y, Direction.up, predator)))
            {
                if (Retreat(this, Direction.down))
                {
                    return true;
                }
            }
            if (Convert.ToBoolean(Seek(location.x, location.y, Direction.down, predator)))
            {
                if (Retreat(this, Direction.up))
                {
                    return true;
                }
            }
            if (Convert.ToBoolean(Seek(location.x, location.y, Direction.left, predator)))
            {
                if (Retreat(this, Direction.right))
                {
                    return true;
                }
            }
            if (Convert.ToBoolean(Seek(location.x, location.y, Direction.right, predator)))
            {
                if (Retreat(this, Direction.left))
                {
                    return true;
                }
            }

            return false;
        }
    }

}
