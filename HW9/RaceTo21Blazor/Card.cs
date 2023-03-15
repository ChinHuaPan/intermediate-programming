using System;
using System.Collections.Generic;

namespace RaceTo21Blazor
{
    public class Card
    {
        private Values Value { get; set; }
        private Suits Suit { get; set; }

        public Card(Values value, Suits suit)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name
        {
            get { return $"{(int)Value} of {Suit}"; }
        }

        public int CardValue
        {
            get { return (int)Value; }
        }

        public string CardSuit
        {
            get { return $"{Suit}"; }
        }

        public string Id
        {
            get {

                return $"{ (int)Value}{Suit.ToString().Substring(0,1)}"; }
        }

    }

    public enum Suits
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    public enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

}
