using System;

namespace ZooManager
{
    public class Cat : Animal
    {
        public Cat(string name)
        {
            emoji = "🐱";
            species = "cat";
            this.name = name;
            reactionTime = new Random().Next(1, 6); // reaction time 1 (fast) to 5 (medium)
        }

        public override bool Activate()
        {
            base.Activate();
            Console.WriteLine("I am a cat. Meow.");

            if(Flee()) return true;
            if(Hunt()) return true;
            return false;

        }

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

        /* Note that our cat is currently not very clever about its hunting.
         * It will always try to attack "up" and will only seek "down" if there
         * is no mouse above it. This does not affect the cat's effectiveness
         * very much, since the overall logic here is "look around for a mouse and
         * attack the first one you see." This logic might be less sound once the
         * cat also has a predator to avoid, since the cat may not want to run in
         * to a square that sets it up to be attacked!
         */

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

