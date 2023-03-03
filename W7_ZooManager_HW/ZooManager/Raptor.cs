using System;
namespace ZooManager
{
    public class Raptor : Bird
    {
        public Raptor(string name)
        {
            emoji = "🦅";
            species = "raptor";
            this.name = name;
            reactionTime = 1; // reaction time 1 (fast) to 5 (medium)
        }

        public override bool Activate()
        {
            base.Activate();
            Console.WriteLine("I am a raptor.");
            if (Hunt()) return true;
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
        string[] prey = { "cat", "mouse" };
        public bool Hunt()
        {
            for (int i = 0; i < prey.Length; i++)
            {
                if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.up, prey[i])))
                {
                    if (Animal.Attack(this, Direction.up))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.down, prey[i])))
                {
                    if (Animal.Attack(this, Direction.down))
                    {
                        return true;
                    }
                }
                else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.left, prey[i])))
                {
                    if (Animal.Attack(this, Direction.left))
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
