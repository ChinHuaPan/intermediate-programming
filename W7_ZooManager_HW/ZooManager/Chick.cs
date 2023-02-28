using System;
namespace ZooManager
{
    public class Chick : Bird
    {
        public Chick()
        {
            emoji = "🐥";
            species = "mouse";
            this.name = name; // "this" to clarify instance vs. method parameter
            reactionTime = new Random().Next(6, 10); // reaction time of 6 (fast) to 10

        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a mouse. Squeak.");
            Flee();
        }

        public void Flee()
        {
            if (Animal.Seek(location.x, location.y, Direction.up, "cat"))
            {
                if (Animal.Retreat(this, Direction.down)) return;
            }
            if (Animal.Seek(location.x, location.y, Direction.down, "cat"))
            {
                if (Animal.Retreat(this, Direction.up)) return;
            }
            if (Animal.Seek(location.x, location.y, Direction.left, "cat"))
            {
                if (Animal.Retreat(this, Direction.right)) return;
            }
            if (Animal.Seek(location.x, location.y, Direction.right, "cat"))
            {
                if (Animal.Retreat(this, Direction.left)) return;
            }
        }

    }
}
