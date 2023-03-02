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

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a raptor.");
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
        string[] prey = { "cat", "mouse" };
        public void Hunt()
        {
            for(int i = 0; i < prey.Length; i++)
            {

            
                if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.up, prey[i])))
                {
                    Animal.Attack(this, Direction.up);
                }
                else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.down, prey[i])))
                {
                    Animal.Attack(this, Direction.down);
                }
                else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.left, prey[i])))
                {
                    Animal.Attack(this, Direction.left);
                }
                else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.right, prey[i])))
                {
                    Animal.Attack(this, Direction.right);
                }

            }
        }
    }
}
