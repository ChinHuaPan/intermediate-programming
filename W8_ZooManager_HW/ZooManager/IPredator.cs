using System;
namespace ZooManager
{
    /////////////// 👉 Goal 2: create IPredat  /////////////////
    public interface IPredator
    {
        public bool Hunt()
        {
            return true;
        }
    }
}
