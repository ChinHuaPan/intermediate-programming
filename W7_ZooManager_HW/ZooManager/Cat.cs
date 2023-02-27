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

        bool goHunt;
        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a cat. Meow.");
            goHunt = true;

            Flee();

            if (goHunt)
            {
                Hunt();
            }

        }

        public void Flee()
        {
            if (Animal.Seek(location.x, location.y, Direction.up, "raptor"))
            {
                if (Animal.Retreat(this, Direction.down))
                {
                    goHunt = false;
                    return;
                }
            }
            if (Animal.Seek(location.x, location.y, Direction.down, "raptor"))
            {
                if (Animal.Retreat(this, Direction.up))
                {
                    goHunt = false;
                    return;
                }
            }
            if (Animal.Seek(location.x, location.y, Direction.left, "raptor"))
            {
                if (Animal.Retreat(this, Direction.right))
                {
                    goHunt = false;
                    return;
                }
            }
            if (Animal.Seek(location.x, location.y, Direction.right, "raptor"))
            {
                if (Animal.Retreat(this, Direction.left))
                {
                    goHunt = false;
                    return;
                }
            }
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
        public void Hunt()
        {
            for (int i = 0; i < prey.Length; i++)
            {
                if (Animal.Seek(location.x, location.y, Direction.up, prey[i]))
                {
                    Animal.Attack(this, Direction.up);
                }
                else if (Animal.Seek(location.x, location.y, Direction.down, prey[i]))
                {
                    Animal.Attack(this, Direction.down);
                }
                else if (Animal.Seek(location.x, location.y, Direction.left, prey[i]))
                {
                    Animal.Attack(this, Direction.left);
                }
                else if (Animal.Seek(location.x, location.y, Direction.right, prey[i]))
                {
                    Animal.Attack(this, Direction.right);
                }
            }
        }
    }
}

