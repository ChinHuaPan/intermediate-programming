using System;
namespace ZooManager
{
    public class Raptor : Bird
    {
        public Raptor()
        {
            emoji = "🦅";
            species = "raptor";
            this.name = name;
            reactionTime = 1; // reaction time 1 (fast) to 5 (medium)
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a cat. Meow.");
            Hunt();
        }

        /* Note that our cat is currently not very clever about its hunting.
         * It will always try to attack "up" and will only seek "down" if there
         * is no mouse above it. This does not affect the cat's effectiveness
         * very much, since the overall logic here is "look around for a mouse and
         * attack the first one you see." This logic might be less sound once the
         * cat also has a predator to avoid, since the cat may not want to run in
         * to a square that sets it up to be attacked!
         */
        public void Hunt()
        {
            if (Animal.Seek(location.x, location.y, Direction.up, "cat"))
            {
                Animal.Attack(this, Direction.up);
            }
            else if (Animal.Seek(location.x, location.y, Direction.down, "cat"))
            {
                Animal.Attack(this, Direction.down);
            }
            else if (Animal.Seek(location.x, location.y, Direction.left, "cat"))
            {
                Animal.Attack(this, Direction.left);
            }
            else if (Animal.Seek(location.x, location.y, Direction.right, "cat"))
            {
                Animal.Attack(this, Direction.right);
            }
        }
    }
}
