using System;
namespace ZooManager
{
    /////////////// 👉 Goal 3: create Alien class /////////////////
    public class Alien : Creature, IPredator
    {
        public Alien(string name)
        {
            emoji = "👽";
            name = "alien";
            reactionTime = 1; //may change is the future
            
        }

        /*********** Activate() *************
        * Act a movement and return whether it has movement or not
        * Called by Game class
        * INPUT: none
        * OUTPUT: bool --> whether it has movement
        * **/
        override public bool Activate()
        {
            Console.WriteLine($"Alien {name} at {location.x},{location.y} activated");
            if(Hunt()) return true;
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
        static public int Seek(int x, int y, Direction direction, int distance = 1) //give distance a temporary default value
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
                if (Game.creatureZones[y][x].occupant == null)
                {
                    return 0;
                }
                //if it finds out anything not Alien successfully
                if(Game.creatureZones[y][x].occupant.GetType() != typeof(Alien))
                {
                    return currentDistance;
                };
            }
            return 0;

        }

        /*********** Hunt() *************
          * Find out anything to hunt
          * Called by Activate method
          * INPUT: none
          * OUTPUT: bool --> whether it has movement
          * **/
        public bool Hunt()
        {
                if (Convert.ToBoolean(Seek(location.x, location.y, Direction.up)))
                {
                    if (Creature.Attack(this, Direction.up))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Seek(location.x, location.y, Direction.down)))
                {
                    if (Creature.Attack(this, Direction.down))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Seek(location.x, location.y, Direction.left)))
                {
                    if (Creature.Attack(this, Direction.left))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Seek(location.x, location.y, Direction.right)))
                {
                    if (Creature.Attack(this, Direction.right))
                    {
                        return true;
                    }
                }
                return false;
            }
    }
}
