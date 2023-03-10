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

        /////////////// 👉 o: fix multiple Activate()  /////////////////
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

            /////////////// 👉 e: Modify the Cat hunts Mouse and Chick, avoids Raptor priority /////////////
            if (Flee()) return true;
            if(Hunt()) return true;
            return false;

        }

        /*********** Flee() *************
         * Find out raptor to flee
         * Called by: none
         * INPUT: none
         * OUTPUT: bool --> whether it has movement
         * **/
        public bool Flee()
        {
            if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.up, "raptor")))
            {
                if (Animal.Retreat(this, Direction.down))
                {
                    return true;
                }
            }
            if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.down, "raptor")))
            {
                if (Animal.Retreat(this, Direction.up))
                {
                    return true;
                }
            }
            if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.left, "raptor")))
            {
                if (Animal.Retreat(this, Direction.right))
                {
                    return true;
                }
            }
            if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.right, "raptor")))
            {
                if (Animal.Retreat(this, Direction.left))
                {
                    return true;
                }
            }

            return false;
        }

        /////////////// 👉 e: Modify the Cat hunts Mouse and Chick, avoids Raptor priority /////////////////
        /*********** Hunt() *************
         * Find out mouse and chick to hunt
         * Called by: none
         * INPUT: none
         * OUTPUT: bool --> whether it has movement
         * **/
        string[] prey = { "mouse", "chick" };
        public bool Hunt()
        {
            for (int i = 0; i < prey.Length; i++)
            {
                if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.up, prey[i])))
                {
                    if(Animal.Attack(this, Direction.up))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.down, prey[i])))
                {
                    if(Animal.Attack(this, Direction.down))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.left, prey[i])))
                {
                    if(Animal.Attack(this, Direction.left))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.right, prey[i])))
                {
                    if (Animal.Attack(this, Direction.right))
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
    }
}

