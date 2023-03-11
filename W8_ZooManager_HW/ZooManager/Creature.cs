using System;
namespace ZooManager
{
    public class Creature
    {

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

        /*********** Attack() *************
       * Attack an target animal, replace it by attacker
       * Called by Hunt() method
       * INPUT: Animal attacker --> attacker animal
       *        Direction d --> attack direction
       * OUTPUT: bool --> return whether attack or not
       * **/
        static public bool Attack(Creature attacker, Direction d)
        {
            Console.WriteLine($"{attacker.name} is attacking {d.ToString()}");
            int x = attacker.location.x;
            int y = attacker.location.y;

            Game.creatureZones[y][x].occupant = null; //remove the attacker from the current location

            //replace the animal which is hunted by attacker
            switch (d)
            {
                case Direction.up:
                    Game.creatureZones[y - 1][x].occupant = attacker;
                    return true;
                case Direction.down:
                    Game.creatureZones[y + 1][x].occupant = attacker;
                    return true;
                case Direction.left:
                    Game.creatureZones[y][x - 1].occupant = attacker;
                    return true;
                case Direction.right:
                    Game.creatureZones[y][x + 1].occupant = attacker;
                    return true;
            }
            return false;
        }

        /*********** Retreat() *************
        * Retreat from an target animal
        * Called by Flee() method
        * INPUT: Animal runner --> runner animal
        *        Direction d --> retreat direction
        * OUTPUT: bool --> return whether retreat or not
        * **/
        static public bool Retreat(Creature runner, Direction d)
        {
            Console.WriteLine($"{runner.name} is retreating {d.ToString()}");
            int x = runner.location.x;
            int y = runner.location.y;

            switch (d)
            {
                case Direction.up:
                    if (y > 0 && Game.creatureZones[y - 1][x].occupant == null)
                    {
                        Game.creatureZones[y - 1][x].occupant = runner;
                        Game.creatureZones[y][x].occupant = null;
                        return true; // retreat was successful
                    }
                    return false; // retreat was not successful
                case Direction.down:
                    if (y < Game.numCellsY - 1 && Game.creatureZones[y + 1][x].occupant == null)
                    {
                        Game.creatureZones[y + 1][x].occupant = runner;
                        Game.creatureZones[y][x].occupant = null;
                        return true;
                    }
                    return false;
                case Direction.left:
                    if (x > 0 && Game.creatureZones[y][x - 1].occupant == null)
                    {
                        Game.creatureZones[y][x - 1].occupant = runner;
                        Game.creatureZones[y][x].occupant = null;
                        return true;
                    }
                    return false;
                case Direction.right:
                    if (x < Game.numCellsX - 1 && Game.creatureZones[y][x + 1].occupant == null)
                    {
                        Game.creatureZones[y][x + 1].occupant = runner;
                        Game.creatureZones[y][x].occupant = null;
                        return true;
                    }
                    return false;
            }
            return false; // fallback
        }


        /////////////// 👉 Goal 1: g/ create move method and modify mouse.flee()  /////////////////
        /*********** Move() *************
        * Move from an target animal
        * Called by flee method
        * INPUT: Animal mover --> mover animal
        *        Direction dir --> move direction
        *        int distance --> move distance
        * OUTPUT: int --> return the move distance
        * **/
        static public int Move(Creature mover, Direction direction, int distance = 1)
        {
            Console.WriteLine($"{mover.name} is moving {direction.ToString()}");
            int x = mover.location.x;
            int y = mover.location.y;

            for (int currentDistance = 1; currentDistance <= distance; currentDistance++)
            {
                switch (direction)
                {
                    case Direction.up:
                        if (y > 0 && Game.creatureZones[y - currentDistance][x].occupant == null)
                        {
                            Game.creatureZones[y - currentDistance][x].occupant = mover;
                            Game.creatureZones[y - (currentDistance - 1)][x].occupant = null;
                        }
                        else
                        {
                            return currentDistance - 1;
                        }

                        break;
                    case Direction.down:
                        if (y < Game.numCellsY - 1 && Game.creatureZones[y + currentDistance][x].occupant == null)
                        {
                            Game.creatureZones[y + currentDistance][x].occupant = mover;
                            Game.creatureZones[y + (currentDistance - 1)][x].occupant = null;
                        }
                        else
                        {
                            return currentDistance - 1;
                        }
                        break;
                    case Direction.left:
                        if (x > 0 && Game.creatureZones[y][x - currentDistance].occupant == null)
                        {
                            Game.creatureZones[y][x - currentDistance].occupant = mover;
                            Game.creatureZones[y][x - (currentDistance - 1)].occupant = null;
                        }
                        else
                        {
                            return currentDistance - 1;
                        }
                        break;
                    case Direction.right:
                        if (x < Game.numCellsX - 1 && Game.creatureZones[y][x + currentDistance].occupant == null)
                        {
                            Game.creatureZones[y][x + currentDistance].occupant = mover;
                            Game.creatureZones[y][x + (currentDistance - 1)].occupant = null;
                        }
                        else
                        {
                            return currentDistance - 1;
                        }
                        break;
                }


            }
            return 0; // fallback
        }
}

}
