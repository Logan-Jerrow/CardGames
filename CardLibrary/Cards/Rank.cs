using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Cards
{
    public sealed class Rank : SmartEnum<Rank>
    {
        internal static readonly Rank Ace = new Rank(nameof(Ace), 1);
        internal static readonly Rank Two = new Rank(nameof(Two), 2);
        internal static readonly Rank Three = new Rank(nameof(Three), 3);
        internal static readonly Rank Four = new Rank(nameof(Four), 4);
        internal static readonly Rank Five = new Rank(nameof(Four), 5);
        internal static readonly Rank Six = new Rank(nameof(Four), 6);
        internal static readonly Rank Seven = new Rank(nameof(Four), 7);
        internal static readonly Rank Eight = new Rank(nameof(Four), 8);
        internal static readonly Rank Nine = new Rank(nameof(Four), 9);
        internal static readonly Rank Ten = new Rank(nameof(Four), 10);

        private Rank(string name, int value) : base(name, value) { }
    }
}
