using System;
namespace ZooManager
{
    /////////////// 👉 Goal 3: create Alien  /////////////////
    public class Alien : Creature, IPredator
    {
        public Alien(string name)
        {
            emoji = "👽";
            name = "alien";
            reactionTime = 1; // default reaction time for animals (1 - 10)
                              //public int distance;
        }


        /*********** Activate() *************
        * Find out something to hunt, flee or do nothing, and return whether has a movement or not
        * Called by Game class
        * INPUT: none
        * OUTPUT: bool --> whether it has movement
        * **/
        override public bool Activate()
        {
            Console.WriteLine($"Alien {name} at {location.x},{location.y} activated");
            //if (Hunt()) return true;
            return false;
        }


        /*********** Hunt() *************
          * Find out mouse and chick to hunt
          * Called by: none
          * INPUT: none
          * OUTPUT: bool --> whether it has movement
          * **/
        //string[] prey = { "mouse", "chick" };
        //public bool Hunt()
        //{
        //    for (int i = 0; i < prey.Length; i++)
        //    {
        //        if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.up, prey[i])))
        //        {
        //            if (Animal.Attack(this, Direction.up))
        //            {
        //                return true;
        //            }
        //        }
        //        else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.down, prey[i])))
        //        {
        //            if (Animal.Attack(this, Direction.down))
        //            {
        //                return true;
        //            }
        //        }
        //        else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.left, prey[i])))
        //        {
        //            if (Animal.Attack(this, Direction.left))
        //            {
        //                return true;
        //            }
        //        }
        //        else if (Convert.ToBoolean(Animal.Seek(location.x, location.y, Direction.right, prey[i])))
        //        {
        //            if (Animal.Attack(this, Direction.right))
        //            {
        //                return true;
        //            }
        //        }
        //        return false;
        //    }
        //    return false;
        //}
    }
}
