using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Cards
{
    public sealed class Suit : SmartEnum<Suit>
    {
        internal static readonly Suit Spades = new Suit(nameof(Spades), 1);
        internal static readonly Suit Hearts = new Suit(nameof(Hearts), 2);
        internal static readonly Suit Diamonds = new Suit(nameof(Diamonds), 3);
        internal static readonly Suit Clubs = new Suit(nameof(Clubs), 4);

        private Suit(string name, int value) : base(name, value) { }
    }
}
