using System;
namespace ZooManager
{
    public class Animal
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

        /////////////// 👉 o: fix multiple Activate()  /////////////////
        /*********** Activate() *************
         * Act a movement and return whether it has movement or not
         * Called by Game class
         * INPUT: none
         * OUTPUT: bool --> has movement or not
         * **/
        virtual public bool Activate()
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
                if (Game.animalZones[y][x].occupant == null) return 0;
                if (Game.animalZones[y][x].occupant.species == target)
                {
                    return currentDistance;
                }
            }
            return 0;
            
        }


        /*********** Attack() *************
        * Attack an target animal, replace it by attacker
        * Called by Hunt() method
        * INPUT: Animal attacker --> attacker animal
        *        Direction d --> attack direction
        * OUTPUT: bool --> return whether attack or not
        * **/
        static public bool Attack(Animal attacker, Direction d)
        {
            Console.WriteLine($"{attacker.name} is attacking {d.ToString()}");
            int x = attacker.location.x;
            int y = attacker.location.y;

            Game.animalZones[y][x].occupant = null; //remove the attacker from the current location

            //replace the animal which is hunted by attacker
            switch (d)
            {
                case Direction.up:
                    Game.animalZones[y - 1][x].occupant = attacker;
                    return true;
                case Direction.down:
                    Game.animalZones[y + 1][x].occupant = attacker;
                    return true;
                case Direction.left:
                    Game.animalZones[y][x - 1].occupant = attacker;
                    return true;
                case Direction.right:
                    Game.animalZones[y][x + 1].occupant = attacker;
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
        static public bool Retreat(Animal runner, Direction d)
        {
            Console.WriteLine($"{runner.name} is retreating {d.ToString()}");
            int x = runner.location.x;
            int y = runner.location.y;

            switch (d)
            {
                case Direction.up:
                    if (y > 0 && Game.animalZones[y - 1][x].occupant == null)
                    {
                        Game.animalZones[y - 1][x].occupant = runner;
                        Game.animalZones[y][x].occupant = null;
                        return true; // retreat was successful
                    }
                    return false; // retreat was not successful
                case Direction.down:
                    if (y < Game.numCellsY - 1 && Game.animalZones[y + 1][x].occupant == null)
                    {
                        Game.animalZones[y + 1][x].occupant = runner;
                        Game.animalZones[y][x].occupant = null;
                        return true;
                    }
                    return false;
                case Direction.left:
                    if (x > 0 && Game.animalZones[y][x - 1].occupant == null)
                    {
                        Game.animalZones[y][x - 1].occupant = runner;
                        Game.animalZones[y][x].occupant = null;
                        return true;
                    }
                    return false;
                case Direction.right:
                    if (x < Game.numCellsX - 1 && Game.animalZones[y][x + 1].occupant == null)
                    {
                        Game.animalZones[y][x + 1].occupant = runner;
                        Game.animalZones[y][x].occupant = null;
                        return true;
                    }
                    return false;
            }
            return false; // fallback
        }


        /*********** Move() *************
        * Move from an target animal
        * Called by 
        * INPUT: Animal mover --> mover animal
        *        Direction dir --> move direction
        *        int distance --> move distance
        * OUTPUT: int --> return the move distance
        * **/
        static public int Move(Animal mover, Direction dir, int distance=1)
        {
            Console.WriteLine($"{mover.name} is moving {dir.ToString()}");
            int x = mover.location.x;
            int y = mover.location.y;
            bool IsNoBlock = true;

            switch (dir)
            {
                case Direction.up:

                    for(int i=1; i <= distance; i++)
                    {
                        IsNoBlock = IsNoBlock && (Game.animalZones[y - i][x].occupant == null);

                        if (y > 0 && IsNoBlock)
                            {
                                Game.animalZones[y - distance][x].occupant = mover;
                                Game.animalZones[y][x].occupant = null;
                                return distance; // move was successful
                            }
                        }

                    
                    return 0; // move was not successful

                case Direction.down:

                    for (int i = 1; i <= distance; i++)
                    {
                        IsNoBlock = IsNoBlock && (Game.animalZones[y + i][x].occupant == null);

                        if (y < Game.numCellsY - 1 && IsNoBlock)
                        {
                            Game.animalZones[y + distance][x].occupant = mover;
                            Game.animalZones[y][x].occupant = null;
                            return distance;
                        }
                    }

                    
                    return 0;

                case Direction.left:

                     for (int i = 1; i <= distance; i++)
                    {
                        IsNoBlock = IsNoBlock && (Game.animalZones[y][x - i].occupant == null);

                        if (x > 0 && IsNoBlock)
                        {
                            Game.animalZones[y][x - distance].occupant = mover;
                            Game.animalZones[y][x].occupant = null;
                            return distance;
                        }
                    }

                    
                    return 0;

                case Direction.right:

                    for (int i = 1; i <= distance; i++)
                    {
                        IsNoBlock = IsNoBlock && (Game.animalZones[y][x + i].occupant == null);

                        if (x < Game.numCellsX - 1 && IsNoBlock)
                        {
                            Game.animalZones[y][x + distance].occupant = mover;
                            Game.animalZones[y][x].occupant = null;
                            return distance;
                        }
                    }

                    
                    return 0;
            }
            return 0; // fallback
        }
    }
}
