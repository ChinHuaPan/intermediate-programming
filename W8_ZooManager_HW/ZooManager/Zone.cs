﻿using System;
namespace ZooManager
{
    public class Zone
    {
        private Creature _occupant = null;
        public Creature occupant
        {
            get { return _occupant; }
            set {
                _occupant = value;
                if (_occupant != null) {
                    _occupant.location = location;
                }
            }
        }

        public Point location;

        public string emoji
        {
            get
            {
                if (occupant == null) return "";
                return occupant.emoji;
            }
        }

        public string rtLabel
        {
            get
            {
                if (occupant == null) return "";
                return occupant.reactionTime.ToString();
            }
        }

        public Zone(int x, int y, Animal animal)
        {
            location.x = x;
            location.y = y;

            occupant = animal;
        }
    }
}
