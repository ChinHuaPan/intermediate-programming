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

        /*********** Activate() *************
         * Find out something to hunt or do nothing
         * Called by Game class
         * INPUT: none
         * OUTPUT: bool --> whether it has movement
         * **/
        public override bool Activate()
        {
            base.Activate();
            Console.WriteLine("I am a raptor.");
            if (Hunt()) return true;
            return false;
        }

        /*********** Hunt() *************
         * Find out cat or mouse to hunt or do nothing
         * Called by: none
         * INPUT: none
         * OUTPUT: bool --> whether it hunt or not
         * **/
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
